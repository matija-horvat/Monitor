using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Monitor.Helpers
{
    class Basic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="hideId">Hide all columns wich name ends with'id'.</param>
        /// <param name="ColumnToShow">Show only this column. String.Empty for showing all.</param>
        public static void FitGridColumns(ref GridView gridView, bool hideId, string ColumnToShow)
        {
            if (gridView is GridView)
            {
                // auto best fit...
                (gridView as GridView).BestFitMaxRowCount = 5000;   // just to avoid to many compares
                (gridView as GridView).BestFitColumns();
                foreach (GridColumn item in (gridView as GridView).Columns) // reduce the width of very wide columns
                {
                    item.Width = (item.Width > 1000) ? 1000 : item.Width;
                }
            }

            //hide id column
            if (hideId)
            {
                foreach (GridColumn item in gridView.Columns)
                {
                    if ((item.FieldName.Substring(item.FieldName.Length - 2, 2)).ToUpper().ToString() == ("id").ToUpper().ToString())
                    {
                        item.Visible = false;
                    }
                }
            }
            

            //hide all columns except Naziv
            if (ColumnToShow != String.Empty)
            {
                foreach (GridColumn item in gridView.Columns)
                {
                    if (item.FieldName != ColumnToShow)
                    {
                        item.Visible = false;
                    }
                }
            }
            

        }

        public static bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public static string ParseDatabase(string stringForParse)
        {
            int databaseIndex = 0;
            string database = String.Empty;
            string connString = stringForParse.ToUpper().ToString();


            if (connString.IndexOf("INITIAL CATALOG") == -1)
            {
                if (connString.IndexOf("DATABASE") == -1)
                {
                    if (connString.IndexOf("ATTACHDBFILENAME") == -1)
                    {
                        return String.Empty;
                    }
                    else
                    {
                        databaseIndex = connString.IndexOf("ATTACHDBFILENAME");
                    }
                }
                else
                {
                    databaseIndex = connString.IndexOf("DATABASE");
                }
            }
            else
            {
                databaseIndex = connString.IndexOf("INITIAL CATALOG");
            }


            connString = connString.Substring(databaseIndex);
            databaseIndex = connString.IndexOf("=")+1;
            //database = stringForParse.Substring(databaseIndex);

            foreach (Char sign in connString.Substring(databaseIndex))
            {
                if (sign == ';')
                {
                    break;
                }

                database = database + sign;
            }

            return database;
        
        
        }

        public static string ParseScriptForStoreName(string stringForParse)
        {
            int openBracketIndex = 0;
            int closedBracketIndex = 0;
            string proc = String.Empty;
            string procedure = stringForParse.ToLower().ToString();

            if (procedure.LastIndexOf("[") == -1)
                return String.Empty;
            else
                openBracketIndex = procedure.LastIndexOf("[") + 1;

            if (procedure.LastIndexOf("]") == -1)
                return String.Empty;
            else
                closedBracketIndex = procedure.LastIndexOf("]") ;




            procedure = procedure.Substring(openBracketIndex, closedBracketIndex - openBracketIndex);
            //proc = procedure.Substring(0, procedure.Length - 1);
            return procedure;
        }

        public static List<SqlParameter> ParseScriptForParameters(string script)
        { 
            
            int paramNumber = 0;
            string paramStringList = String.Empty;
            string paramName = String.Empty;
            string paramValue = String.Empty;
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (script.LastIndexOf("]") != -1)
	        {
                paramStringList = script.Substring(script.LastIndexOf("]") + 1);
            }

            paramStringList.Trim();

            paramNumber = paramStringList.Split('=').Length - 1;
            

            for (int i = 0; i < paramNumber; i++)
			{
                paramName = paramStringList.Substring(paramStringList.IndexOf("@"), paramStringList.IndexOf("=") - paramStringList.IndexOf("@"));
                if (paramStringList.IndexOf(",") == -1)
                {
                    paramValue = paramStringList.Substring(paramStringList.IndexOf("=") + 1);
                }
                else
                    paramValue = paramStringList.Substring(paramStringList.IndexOf("=") + 1, paramStringList.IndexOf(",") - paramStringList.IndexOf("=") - 1);

                parameters.Add(new SqlParameter(paramName, paramValue));

                paramStringList = paramStringList.Substring(paramStringList.IndexOf(",") + 1);
                paramStringList.Trim();

			}
            
            
            return parameters;
        
        }

        public static SaveFileDialog PrepareSaveDialog()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|SQL files (*.sql)|*.sql";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            return saveFileDialog1;
        }
    }
}
