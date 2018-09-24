using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0917Service
{
    public partial class Service1 : ServiceBase
    {

        
        public Service1()
        {
            InitializeComponent();
        }
        
       
        Queue<string> Q = new Queue<string>();

        // variables to hold the literal path locations 
        public string WATCHPATH = @"C:\Users\Cyberadmin\Desktop";
        public string BACKUPPATH = @"C:\Users\Cyberadmin\Downloads\BackupFolder";

        StreamWriter writer = new StreamWriter(@"C:\Users\Cyberadmin\Desktop\File.txt", true);


        protected override void OnStart(string[] args)
        {
            watcher(WATCHPATH);
            

        }

        protected override void OnStop()
        {           
            
         // writer.WriteLine(Q.Count.ToString());
            //writer.Close();
        }

        // FileSystemWatcher method
        private void watcher(string Path)
            { 
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.IncludeSubdirectories = true;
            watcher.Path = WATCHPATH;
            watcher.NotifyFilter = NotifyFilters.FileName;              

            if (watcher != null)
                             
            {
                watcher.Created += Watcher_Created;
                watcher.Changed += Watcher_Changed;
                watcher.Renamed += Watcher_Renamed;
                watcher.Deleted += Watcher_Deleted;
                watcher.EnableRaisingEvents = true;
            }

        }
        

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            //TextWriter writer = new StreamWriter("C:/Users/Cyberadmin/Documents/File.txt", true);
            writer.WriteLine(DateTime.Now + "A new folder with the name " + e.Name + " has been created.");
        

            Q.Enqueue(e.Name);

        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            //TextWriter writer = new StreamWriter("C:/Users/Cyberadmin/Documents/File.txt", true);
            writer.WriteLine(DateTime.Now + "A new folder with the name " + e.Name + " has been Altered.");
        

            Q.Enqueue(e.Name);

        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
           // TextWriter writer = new StreamWriter("C:/Users/Cyberadmin/Documents/File.txt", true);
            writer.WriteLine(DateTime.Now + "A new folder with the name " + e.Name + " has been Deleted.");
            
            // nothing here you cant copy a deleted file, its already gone

        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            //TextWriter writer = new StreamWriter("C:/Users/Cyberadmin/Documents/File.txt", true);
            writer.WriteLine(DateTime.Now + "A new folder with the name " + e.Name + " has been Renamed.");
      

            Q.Enqueue(e.Name);
        }

            // the timer function. 
        
        internal void startandstop(string[] args)
        {
            this.OnStart(args);
            

            while (ServTimer.Enabled)
            {
                Console.ReadLine();         
                
            }
            
            this.OnStop();
           // writer.Close();
            
        }

        private void ServTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            writer.Close();    

        }
    }
}
