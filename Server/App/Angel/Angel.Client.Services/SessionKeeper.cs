namespace Angel.Client.Services
{
    public class SessionKeeper : ISessionKeeper
    {
        private bool _isAuth = false;

        public SessionKeeper()
        {

        }

        public bool IsAuth { get; set; }
    }
}
