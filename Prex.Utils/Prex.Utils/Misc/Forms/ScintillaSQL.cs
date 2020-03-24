using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prex.Utils.Misc.Forms
{
    public static class ScintillaSQL
    {

        public static void InitialiseScintilla(Scintilla scintilla1)
        {
           
            //Set the line numbers 
            scintilla1.Margins[0].Width = 16;

            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = "Consolas";
            scintilla1.Styles[Style.Default].Size = 10;
            scintilla1.StyleClearAll();

            scintilla1.Styles[Style.Sql.Character].ForeColor = Color.Black;

            //surrounded by /* */
            scintilla1.Styles[Style.Sql.Comment].ForeColor = Color.Green;

            //begins with --
            scintilla1.Styles[Style.Sql.CommentLine].ForeColor = Color.Green;

            scintilla1.Styles[Style.Sql.CommentDoc].ForeColor = Color.Black;
            scintilla1.Styles[Style.Sql.CommentDocKeyword].ForeColor = Color.Black;
            scintilla1.Styles[Style.Sql.CommentDocKeywordError].ForeColor = Color.Black;
            scintilla1.Styles[Style.Sql.CommentLineDoc].ForeColor = Color.Black;

            //Any text?
            scintilla1.Styles[Style.Sql.Identifier].ForeColor = Color.Black;

            //just a number
            scintilla1.Styles[Style.Sql.Number].ForeColor = Color.Black;

            //+= <> - etc
            scintilla1.Styles[Style.Sql.Operator].ForeColor = Color.Black;
            scintilla1.Styles[Style.Sql.QOperator].ForeColor = Color.Black;
            scintilla1.Styles[Style.Sql.QuotedIdentifier].ForeColor = Color.Black;
            scintilla1.Styles[Style.Sql.SqlPlus].ForeColor = Color.Black;
            scintilla1.Styles[Style.Sql.SqlPlusComment].ForeColor = Color.Black;
            scintilla1.Styles[Style.Sql.SqlPlusPrompt].ForeColor = Color.Black;

            //think it's supposed to be the keywords, but doesn't change them!
            scintilla1.Styles[Style.Sql.Word].ForeColor = Color.Blue;
            scintilla1.Styles[Style.Sql.Word2].ForeColor = Color.Pink;
            


            //in double quotes
            scintilla1.Styles[Style.Sql.String].ForeColor = Color.Red;

            scintilla1.Lexer = Lexer.Sql;
            //scintilla1.Text = scintilla1.DescribeKeywordSets();

            scintilla1.SetKeywords(0, "select where from use go delete update insert group by having drop table exec create view");
            
        }

    }
}
