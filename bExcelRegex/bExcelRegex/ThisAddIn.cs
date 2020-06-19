using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using bLogger;
using System.IO;
using bExcelRegex.Search;

namespace bExcelRegex
{
    public partial class ThisAddIn
    {
		public enum ShowSource
		{
			Find,
			Replace
		}

        private const string TaskPaneTitle = "bExcelRegex";

        private SearchControl userControl;
        private Microsoft.Office.Tools.CustomTaskPane taskPane;

        private Logger logger;

		private SearchEngine searchEngine;

		internal SearchEngine GetSearchEngine()
		{
			return searchEngine;
		}

		public Logger GetLogger() { return logger; }

		public void ShowTaskPane(bool show, ShowSource showSource)
		{
			taskPane.Visible = show;
		}

		private string GetPluginDirectory()
        {
            return Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData) + "\\bcieszko\\bExcelRegex";
        }

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            if (!Directory.Exists(GetPluginDirectory()))
            {
                Directory.CreateDirectory(GetPluginDirectory());
            }

            // TODO: Multiple excel instances, wont that break? differntiate, add tid/pid suffix?
            logger = new Logger(GetPluginDirectory() + "\\bExcelRegex.log");
			searchEngine = new SearchEngine();

            userControl = new SearchControl();
            taskPane = this.CustomTaskPanes.Add(userControl, TaskPaneTitle);
            taskPane.Visible = false;
			taskPane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionFloating;
			taskPane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionRight;
			taskPane.DockPositionRestrict = Office.MsoCTPDockPositionRestrict.msoCTPDockPositionRestrictNoHorizontal;
			//taskPane.Width =  userControl.size
        }


        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
			taskPane = null;
			userControl.Dispose();
			userControl = null;

			logger.Dispose();
			logger = null;
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
