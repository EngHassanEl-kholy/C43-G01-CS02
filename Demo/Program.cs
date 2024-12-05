namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Comments
            //Single Line Comment
            /**
             * 
             * 
             * 
             * 
             * 
             * Multiline Comment*/
            #endregion

            #region Variables Declration
            // DataType VariableName = Value
            //string Name = "Hassan Elkholy";
            //int Number = 12;
            #endregion

            #region Value Type
            //int Num;
            ////CLR will allocate 4 bytes at stack
            //Num = 5;
            //int X = Num;  //Pass Value Of Num = > x=5
            //Num++;        // Num=6     X=5
            #endregion

            #region Reference Type
            //string name; 
            ////CLR will allocate 4 bytes at stack for the reference (name) which contain on address
            //name = "Hassan";
            //string name2 = name;
            ////pass the reference of name = > name & name2 refer to same object
            //name = "Ahmed";
            //name refer to new object ("Ahmed")
            //name2 still refer to same object ("Hassan")
            #endregion

            #region Object
            //object obj1 = new();
            //object obj2 = new();
            //obj1 = 10;  //Boxing
            //obj2 = obj1; 
            ////obj1 and obj2 refere to same object
            //obj1 = 20;
            ////obj1 refer to new object
            ////object is a parent of all datatypes for 2 reasons
            ////1- Replaces idea of Genereics 
            ////2- Hava set of behavior should be existed with every datatype
            //Console.WriteLine(obj1.ToString());
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj1.GetType());
            //Console.WriteLine(obj1.Equals(obj2));
            #endregion

            #region Fractions
            //double Y = 23.3;
            ////By Default fraction number be double
            //float X = 23.3f;
            //decimal M = 23.3m;
            //long Number = 100_000_000;
            //Console.WriteLine(Number);
            #endregion

            #region Implicit&Explicit Casting
            //int x = 12;
            //long y = x;          //you don't need to cast
            ////Implicit Casting
            //long z = 1000;
            //int w = (int) z;    //you need to cast
            ////Explicit Casting
            #endregion

        }
    }
}
