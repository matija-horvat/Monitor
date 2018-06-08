using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Services;

namespace Monitor.Classes
{
    public class CustomSyntaxHighlightService : ISyntaxHighlightService {
        
        #region #parsetokens
        readonly Document document;
        SyntaxHighlightProperties defaultSettings = new SyntaxHighlightProperties() { ForeColor = Color.Black };
        SyntaxHighlightProperties keywordSettings = new SyntaxHighlightProperties() { ForeColor = Color.Blue };
        SyntaxHighlightProperties stringSettings = new SyntaxHighlightProperties() { ForeColor = Color.Red };
        SyntaxHighlightProperties functionSettings = new SyntaxHighlightProperties() { ForeColor = Color.Fuchsia };
        SyntaxHighlightProperties joinSettings = new SyntaxHighlightProperties() { ForeColor = Color.Gray };

        string[] keywords = new string[] { 
            
            "ADD", "ALTER", "AS", "ASC", "AUTHORIZATION", 
            "BACKUP", "BEGIN", "BREAK", "BROWSE", "BULK", "BY", 
            "CASCADE", "CASE", "CHECK", "CHECKPOINT", "CLOSE", "CLUSTERED", "COLLATE", "COLUMN", "COMMIT", "COMPUTE", 
            "CONSTRAINT", "CONTAINS", "CONTAINSTABLE", "CONTINUE", "CREATE", "CURRENT", "CURRENT_DATE", "CURRENT_TIME", "CURSOR", 
            "DATABASE", "DBCC", "DEALLOCATE", "DECLARE", "DEFAULT", "DELETE", "DENY", "DESC", "DISK", "DISTINCT", 
            "DISTRIBUTED", "DOUBLE", "DROP", "DUMP", 
            "EXTERNAL", "ELSE", "END", "ERRLVL", "ESCAPE", "EXCEPT", "EXEC", "EXECUTE", "EXIT", 
            "FETCH", "FILE", "FILLFACTOR", "FOR", "FOREIGN", "FREETEXT", "FREETEXTTABLE", "FROM", "FULL", "FUNCTION", 
            "GOTO", "GRANT", "GROUP", 
            "HAVING", "HOLDLOCK", 
            "IDENTITY", "IDENTITY_INSERT", "IDENTITYCOL", "IF", "INDEX", "INSERT", "INTERSECT", "INTO", 
            "KILL", "KEY", 
            "LOAD", "LINENO", 
            "MERGE",
            "NATIONAL", "NOCHECK", "NONCLUSTERED", 
            "OFF", "OFFSETS", "ON", "OF", "OPEN", "OPENDATASOURCE", "OPENQUERY", "OPENROWSET", "OPENXML", "OPTION", "ORDER", "OVER", 
            "PROCEDURE", "PUBLIC", "PERCENT", "PLAN", "PRECISION", "PRIMARY", "PRINT", "PROC",
            "RAISERROR", "READ", "READTEXT",  "RECONFIGURE", "REFERENCES", "REPLICATION", "RESTORE", "RESTRICT", "RETURN", 
            "REVERT", "REVOKE",  "ROLLBACK",  "ROWCOUNT", "ROWGUIDCOL", "RULE",  
            "SAVE", "SCHEMA", "SECURITYAUDIT", "SELECT", "SET", "SETUSER", "SHUTDOWN", "STATISTICS", 
            "TABLE", "TABLESAMPLE", "TEXTSIZE", "THEN", "TO", "TOP", "TRAN", "TRANSACTION", "TRIGGER", "TRUNCATE", "TSEQUAL", 
            "UNION", "UNIQUE", "UPDATE", "UPDATETEXT", "USE", 
            "VALUES", "VARYING", "VIEW",
            "WAITFOR", "WHEN", "WHERE", "WHILE", "WITH", "WRITETEXT",
        
            "bigint","bit","binary","char","cursor","decimal","date","datetimeoffset","datetime2","datetime","float",
            "hierarchyid","image","int","money","numeric","real","smallint","smallmoney","smalldatetime","sql_variant",
            "table","tinyint","time","text","timestamp","uniqueidentifier","varchar","varbinary","xml"
        };

        string[] functions = new string[] { 
            "AVG", "CHECKSUM_AGG", "COUNT_BIG", "COUNT", "GROUPING", "GROUPING_ID", "MIN", "MAX", "STDEV", "SUM", "STDEVP", "VAR", "VARP",
            "getdate", "ROW_NUMBER", "CONVERT", "cast", 
            
            "@@DATEFIRST","@@OPTIONS","@@DBTS","@@REMSERVER","@@LANGID","@@SERVERNAME","@@LANGUAGE","@@SERVICENAME",
            "@@LOCK_TIMEOUT","@@SPID","@@MAX_CONNECTIONS","@@TEXTSIZE","@@MAX_PRECISION","@@VERSION","@@NESTLEVEL",
            "@@CURSOR_ROWS", "CURSOR_STATUS", "@@FETCH_STATUS",
            "DATEDIFF", "DATEADD", "datepart", "SWITCHOFFSET", "TODATETIMEOFFSET", "day", "month", "year", "CURRENT_TIMESTAMP",

            "ABS","DEGREES","RAND","ACOS","EXP","ROUND","ASIN","FLOOR","SIGN","ATAN","LOG","SIN","ATN2","LOG10",
            "SQRT","CEILING","PI","SQUARE","COS","POWER","TAN","COT","RADIANS",

            "@@PROCID","INDEX_COL","APP_NAME","INDEXKEY_PROPERTY","APPLOCK_MODE","INDEXPROPERTY","APPLOCK_TEST","ASSEMBLYPROPERTY",
            "OBJECT_DEFINITION","COL_LENGTH","OBJECT_ID","COL_NAME","OBJECT_NAME","COLUMNPROPERTY","OBJECT_SCHEMA_NAME","DATABASE_PRINCIPAL_ID",
            "OBJECTPROPERTY","DATABASEPROPERTYEX","OBJECTPROPERTYEX","DB_ID","ORIGINAL_DB_NAME","DB_NAME","PARSENAME","FILE_ID",
            "SCHEMA_ID","FILE_IDEX","SCHEMA_NAME","FILE_NAME","SCOPE_IDENTITY","FILEGROUP_ID","SERVERPROPERTY","FILEGROUP_NAME","STATS_DATE",
            "FILEGROUPPROPERTY","TYPE_ID","FILEPROPERTY","TYPE_NAME","FULLTEXTCATALOGPROPERTY","TYPEPROPERTY","FULLTEXTSERVICEPROPERTY",

            "PWDCOMPARE", "PWDENCRYPT", "CURRENT_USER", "SCHEMA_ID" ,"DATABASE_PRINCIPAL_ID", "SCHEMA_NAME", 
            "SESSION_USER", "SUSER_ID", "SUSER_SID", "HAS_PERMS_BY_NAME", "SUSER_SNAME", "IS_MEMBER", "SYSTEM_USER", 
            "IS_ROLEMEMBER", "SUSER_NAME", "IS_SRVROLEMEMBER", "USER_ID", "ORIGINAL_LOGIN", "USER_NAME", "PERMISSIONS",

            "ASCII","LTRIM","SOUNDEX","SPACE","CHARINDEX","PATINDEX","STR","QUOTENAME","STUFF","DIFFERENCE","REPLACE",
            "SUBSTRING","REPLICATE","UNICODE","REVERSE","UPPER","LEN","LOWER","RTRIM",

            "$PARTITION","ERROR_SEVERITY","@@ERROR","ERROR_STATE","@@IDENTITY","FORMATMESSAGE","@@PACK_RECEIVED",
            "GETANSINULL","@@ROWCOUNT","@@TRANCOUNT","HOST_ID","BINARY_CHECKSUM","HOST_NAME","CHECKSUM","ISNULL",
            "CONNECTIONPROPERTY","ISNUMERIC","MIN_ACTIVE_ROWVERSION","CURRENT_REQUEST_ID","NEWID","ERROR_LINE",
            "NEWSEQUENTIALID","ERROR_MESSAGE","ERROR_NUMBER","XACT_STATE","ERROR_PROCEDURE",

            "@@CONNECTIONS","@@PACK_RECEIVED","@@CPU_BUSY","@@PACK_SENT","@@TIMETICKS","@@IDLE","@@TOTAL_ERRORS",
            "@@IO_BUSY","@@TOTAL_READ","@@PACKET_ERRORS","@@TOTAL_WRITE",

            "PATINDEX","TEXTVALID","TEXTPTR"
};

        string[] joins = new string[] { 
            "cross apply", "left outer ", "inner", "join", "right outer", "outer", "null", "in", "exists", "not", "like",
        "between", "and", "or"};

        public CustomSyntaxHighlightService(Document document) {
            this.document = document;
        }

        private List<SyntaxHighlightToken> ParseTokens() {
            List<SyntaxHighlightToken> tokens = new List<SyntaxHighlightToken>();
            DocumentRange[] ranges = null;
            // search for quotation marks
            ranges = document.FindAll("'", SearchOptions.None);
            for (int i = 0; i < ranges.Length / 2; i++) {
                tokens.Add(new SyntaxHighlightToken(ranges[i * 2].Start.ToInt(), 
                    ranges[i * 2 + 1].Start.ToInt() - ranges[i * 2].Start.ToInt() + 1, stringSettings));
            }
            // search for keywords
            for (int i = 0; i < keywords.Length; i++) {
                ranges = document.FindAll(keywords[i], SearchOptions.None | SearchOptions.WholeWord);

                for (int j = 0; j < ranges.Length; j++) {
                    if (!IsRangeInTokens(ranges[j], tokens))
                        tokens.Add(new SyntaxHighlightToken(ranges[j].Start.ToInt(), ranges[j].Length, keywordSettings));
                }
            }

            // search for functions
            for (int i = 0; i < functions.Length; i++)
            {
                ranges = document.FindAll(functions[i], SearchOptions.None | SearchOptions.WholeWord);

                for (int j = 0; j < ranges.Length; j++)
                {
                    if (!IsRangeInTokens(ranges[j], tokens))
                        tokens.Add(new SyntaxHighlightToken(ranges[j].Start.ToInt(), ranges[j].Length, functionSettings));
                }
            }

            // search for joins
            for (int i = 0; i < joins.Length; i++)
            {
                ranges = document.FindAll(joins[i], SearchOptions.None | SearchOptions.WholeWord);

                for (int j = 0; j < ranges.Length; j++)
                {
                    if (!IsRangeInTokens(ranges[j], tokens))
                        tokens.Add(new SyntaxHighlightToken(ranges[j].Start.ToInt(), ranges[j].Length, joinSettings));
                }
            }

            // order tokens by their start position
            tokens.Sort(new SyntaxHighlightTokenComparer());
            // fill in gaps in document coverage
            AddPlainTextTokens(tokens);
            return tokens;
        }

        private void AddPlainTextTokens(List<SyntaxHighlightToken> tokens) {
            int count = tokens.Count;
            if (count == 0) {
                tokens.Add(new SyntaxHighlightToken(0, document.Range.End.ToInt(), defaultSettings));
                return;
            }
            tokens.Insert(0, new SyntaxHighlightToken(0, tokens[0].Start, defaultSettings));
            for (int i = 1; i < count; i++) {
                tokens.Insert(i * 2, new SyntaxHighlightToken(tokens[i * 2 - 1].End,
 tokens[i * 2].Start - tokens[i * 2 - 1].End, defaultSettings));
            }
            tokens.Add(new SyntaxHighlightToken(tokens[count * 2 - 1].End,
 document.Range.End.ToInt() - tokens[count * 2 - 1].End, defaultSettings));
        }

        private bool IsRangeInTokens(DocumentRange range, List<SyntaxHighlightToken> tokens) {
            for (int i = 0; i < tokens.Count; i++) {
                if (range.Start.ToInt() >= tokens[i].Start && range.End.ToInt() <= tokens[i].End)
                    return true;
            }
            return false;
        }
        #endregion #parsetokens

        #region #ISyntaxHighlightServiceMembers
        public void ForceExecute() {
            Execute();
        }
        public void Execute() {
            document.ApplySyntaxHighlight(ParseTokens());
            document.DefaultCharacterProperties.FontName = "Courier New";
            document.DefaultCharacterProperties.FontSize = 10;
            
        }
        #endregion #ISyntaxHighlightServiceMembers

        
    }

    #region #SyntaxHighlightTokenComparer
    public class SyntaxHighlightTokenComparer : IComparer<SyntaxHighlightToken> {
        public int Compare(SyntaxHighlightToken x, SyntaxHighlightToken y) {
            return x.Start - y.Start;
        }
    }
    #endregion #SyntaxHighlightTokenComparer

    }

