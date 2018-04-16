namespace VisCs2012Interfaces
{
    abstract class LogBase
    {
        public abstract void Write(string message);
        protected string target;

        public string Target
        {
            get { return target; }
            set { target = value; }
        }
    }
}