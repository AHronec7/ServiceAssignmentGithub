namespace _0917Service
{
    partial class Service1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileSystemWatcher = new System.IO.FileSystemWatcher();
            this.ServTimer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServTimer)).BeginInit();
            // 
            // FileSystemWatcher
            // 
            this.FileSystemWatcher.EnableRaisingEvents = true;
            this.FileSystemWatcher.IncludeSubdirectories = true;
            this.FileSystemWatcher.Path = "C:\\Users\\Cyberadmin\\Documents";
            this.FileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.Watcher_Changed);
            this.FileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.Watcher_Created);
            this.FileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.Watcher_Deleted);
            this.FileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.Watcher_Renamed);
            // 
            // ServTimer
            // 
            this.ServTimer.Enabled = true;
            this.ServTimer.Interval = 10000D;
            this.ServTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.ServTimer_Elapsed);
            // 
            // Service1
            // 
            this.CanHandlePowerEvent = true;
            this.CanPauseAndContinue = true;
            this.ServiceName = "Watcher";
            ((System.ComponentModel.ISupportInitialize)(this.FileSystemWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServTimer)).EndInit();

        }

        #endregion

        private System.IO.FileSystemWatcher FileSystemWatcher;
        private System.Timers.Timer ServTimer;
    }
}
