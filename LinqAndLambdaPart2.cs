/*
	1- Author --> mehrshad
		2 - GitHub --> mehrshad2002
			3 - Linkedin --> Mehrshad Asadi 
				4 - YouYube --> Soon
					5 - Instagram --> mehrshad.codeland
*/

// Lambda and Linq Part<2>
public class App
    {
        public static IO io = new IO();
        public static void Main()
        {
            // create data and object
            List<User> users = new List<User>();
            User user = new User()
            {
                Age = 22,
                Name = "Mehrshad",
                ID = 1
            };
            users.Add(user);

            User user1 = new User()
            {
                Age = 18,
                Name = "Aria",
                ID = 2
            };
            users.Add(user1);


            // *** Lambda Is Here! ***
            var x1 = users.ToArray();
            var x2 = users.Select( u => u.Name == "Aria");
            var x3 = users.Select(u => new { u.Name, u.ID }).ToList();
        }
    }