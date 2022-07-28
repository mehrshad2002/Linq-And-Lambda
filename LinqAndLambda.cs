/*
	1- Author --> mehrshad
		2 - GitHub --> mehrshad2002
			3 - Linkedin --> Mehrshad Asadi 
				4 - YouYube --> Soon
					5 - Instagram --> mehrshad.codeland
*/



// LinQ and Lambda Expression
public class App
    {
        public static IO io = new IO();
        public static void Main()
        {

            // create list 
            List<int> numbers = new List<int>();
            for( int i = 0; i < 25 ; ++i)
            {
                Random random = new Random();
                int randomNumebr = random.Next(0, 1000);
                numbers.Add(randomNumebr);
            }

            // 1
            var x1 = from number in numbers
                     select number;

            var lambda1 = numbers.ToArray();


            // 2
            var x2 = from number in numbers
                     orderby number
                     select number;

            var lambda2 = numbers.OrderBy( x => x ).ToArray();


            // 3 
            var x3 = from number in numbers
                     where number > 25 && number < 500
                     orderby number
                     select number;

            var lambda3 = numbers.Where( x => x > 25 && x< 500 ).OrderBy(x => x ).ToArray();


            // 4 
            var x4 = from number in numbers
                     where number == 200 || number > 500
                     orderby number
                     select number;

            var lambda4 = numbers.Where(x => x == 200 || x > 500).OrderBy(x => x).ToArray();

        }
    }