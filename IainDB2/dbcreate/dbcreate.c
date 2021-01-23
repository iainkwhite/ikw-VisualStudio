
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sqlutil.h>
#include <sqlenv.h>
#include "sqleHUON.h"
#include "utilapi.h"

int DbCreate(char dbaseName[SQL_DBNAME_SZ + 1]);

int main(int argc, char *argv[])
{
  int rc = 0;
  char dbname[SQL_DBNAME_SZ + 1];
  char nodeName[SQL_INSTNAME_SZ + 1];
  char user[USERID_SZ + 1];
  char pswd[PSWD_SZ + 1];

  printf("\ndbcreate: %i arguments entered  ",argc-1);
  for (int i = 1 ; i < argc; ++i)
	printf(" %i: %s ",i,argv[i]);
  printf("\n ");

  /* check the command line arguments */
  rc = CmdLineArgsCheck3(argc, argv, dbname, nodeName, user, pswd);
  if (rc != 0)
  {
    return rc;
  }

  printf("\nCreate a Database with a custom collating sequence.\n\n");
  printf("Parameters:\n");
  printf("<database name>  (defaults to 'sample')\n");
  printf("<instance>       (defaults to local)\n");
  printf("<userid>         (defaults to current id)\n");
  printf("<password>       \n");

  /* attach to a local or remote instance */
  rc = InstanceAttach(nodeName, user, pswd);
  if (rc != 0)
  {
    return rc;
  }

  /* create the database */
  rc = DbCreate(dbname);

  /* detach from the local or remote instance */
  rc = InstanceDetach(nodeName);
  if (rc != 0)
  {
    return rc;
  }

  return 0;
} /* main */

int DbCreate(char dbaseName[SQL_DBNAME_SZ + 1])
{
  struct sqlca sqlca;
  char dbLocalAlias[SQL_ALIAS_SZ + 1];
  char dbPath[SQL_PATH_SZ + 1];
  struct sqledbdesc dbDescriptor;
  SQLEDBTERRITORYINFO territoryInfo;

  /* set up database parameters */
  strcpy(dbLocalAlias, dbaseName);
/*strcpy(dbPath, "/db2db1/test");  */
/*strcpy(dbPath, "/db2/db2path/db2clmdi"); */
  strcpy(dbPath,2,"D:");

  strcpy(dbDescriptor.sqldbdid, SQLE_DBDESC_2);
  dbDescriptor.sqldbccp = 0;
  dbDescriptor.sqldbcss = SQL_CS_USER;
  memcpy(dbDescriptor.sqldbudc, sqle_HUON, SQL_CS_SZ);
  strcpy(dbDescriptor.sqldbcmt, "Uses custom collation");
  dbDescriptor.sqldbsgp = 0;
  dbDescriptor.sqldbnsg = 10;
  dbDescriptor.sqltsext = -1;
  dbDescriptor.sqlcatts = NULL;
  dbDescriptor.sqlusrts = NULL;
  dbDescriptor.sqltmpts = NULL;

  strcpy(territoryInfo.sqldbcodeset, "IBM-850");
  strcpy(territoryInfo.sqldblocale, "En_US");

  printf("\n  Create a database and catalog it locally:\n");
  printf("    database name       : %s\n", dbaseName);
  printf("    local database alias: %s\n", dbLocalAlias);
  printf("    database path       : %s\n", dbPath);
  printf("    database codeset    : %s\n", territoryInfo.sqldbcodeset);
  printf("    database locale     : %s\n", territoryInfo.sqldblocale);

  /* create database */
  printf("\n  Calling DB2 API 'sqlecrea' to create the database...\n");
  sqlecrea(dbaseName,
           dbLocalAlias,
           dbPath,
           &dbDescriptor,
           &territoryInfo,
           '\0',
           NULL,
           &sqlca);
  DB2_API_CHECK("Database -- Create");

  return 0;
} /* DbCreate */

