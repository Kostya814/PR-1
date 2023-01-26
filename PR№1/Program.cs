// See https://aka.ms/new-console-template for more information
namespace PR_1 
{
    class EffectiveProductionSystem
    {
        private List<User> users = new List<User>();
        private List<Request> requests= new List<Request>();
        private List<Instrument> instruments= new List<Instrument>();
        private User currentUser;

        static void Main(string[] args)
        {
            User user = new User("Костя", "kostya", "12345678");
        }
        public void addUser(string name, string login, string password,string repeation,int type)
        {
            users.Add(new User(name, login, password));
        }
        public User findUser(string login, string password) 
        { 

            return (User)users.Where(g=> g.enter(login,password)); 
        }
        public void save()
        { }
        public void load() 
        { }
        public void processRequest() 
        { }
    } 
}
