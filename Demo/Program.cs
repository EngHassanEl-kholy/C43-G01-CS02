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



        }
    }
}
