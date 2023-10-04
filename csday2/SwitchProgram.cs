class SwitchProgram{
    public static void Main(){
        char ch=(char)Console.Read();
        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
              Console.WriteLine("Entered alphabet is an vowel");
              break;
            
            default:
               Console.WriteLine("Entered alphabet is an Consonent");
               break;
               
        }
    }
}