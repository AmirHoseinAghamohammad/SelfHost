namespace WindowsService1
{
    partial class ProjectInstaller
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
            this.WebApiHostServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.WebApiHostServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // WebApiHostServiceProcessInstaller
            // 
            this.WebApiHostServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.WebApiHostServiceProcessInstaller.Password = null;
            this.WebApiHostServiceProcessInstaller.Username = null;
            this.WebApiHostServiceProcessInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.WebApiHostServiceProcessInstaller_AfterInstall);
            // 
            // WebApiHostServiceInstaller
            // 
            this.WebApiHostServiceInstaller.ServiceName = "WebApiHostService";
            this.WebApiHostServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            this.WebApiHostServiceInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.WebApiHostServiceInstaller_AfterInstall);
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.WebApiHostServiceProcessInstaller,
            this.WebApiHostServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller WebApiHostServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller WebApiHostServiceInstaller;
    }
}