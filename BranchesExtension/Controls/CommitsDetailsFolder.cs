using Soneta.Business.Forms.Folders;

namespace enova365.Dodatek1.Controls
{
    public class CommitsDetailsFolder : Folder
    {
        public CommitsDetailsFolder(IFolder parent, Folders folders) 
            : base(parent, folders) {}

        public override CustomView CreateView()
        {
            var userControl = new CommitsDetailsUserControl();
            userControl.InitControls();
            return userControl;
        }
    }
}
