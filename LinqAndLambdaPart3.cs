/*
	1- Author --> mehrshad
		2 - GitHub --> mehrshad2002
			3 - Linkedin --> Mehrshad Asadi 
				4 - YouYube --> Soon
					5 - Instagram --> mehrshad.codeland
*/  



public class App
    {
        public static IO io = new IO();
        public static void Main()
        {
            // create data and object
            List<User> users = new List<User>();
            List<Phone> phones = new List<Phone>();

            // create users
            User user = new User();
            user.Age = 19;
            user.ID = 1;
            user.Name = "Mehrshad";
            users.Add(user);

            User user1 = new User();
            user1.Age = 23;
            user1.Name = "Aria";
            user1.ID = 2;
            users.Add(user1);

            User user2 = new User();
            user2.Age = 11;
            user2.Name = "Bornan";
            user2.ID = 3;
            users.Add(user2);

            // create phones 
            Phone phone = new Phone();
            phone.UserID = 2;
            phone.price = 999;
            phone.PhoneName = "IPhoneX";
            phones.Add(phone);

            Phone phone1 = new Phone();
            phone1.UserID = 7;
            phone1.price = 800;
            phone1.PhoneName = "Samsung20";
            phones.Add(phone1);

			// *** Linq and Lambda ***
            var Join = ( from u in users
                         join p in phones on u.ID equals p.UserID
                         select new
                         {
                             u.ID,
                             u.Name,
                             u.Age,
                             p.PhoneName,
                             p.price
                         }).ToList();

            foreach(var item in Join)
            {
                io.Print($"ID : {item.ID} Name : {item.Name} PhoneName : {item.PhoneName}");
            }
        }
    }