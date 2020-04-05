using System;
using System.Collections.Generic;
using System.Text;

namespace ImpossibleApocalypse.Services
{
    public static class Art
    {
        public static void GameLogo()
        {
            string logo = @"
      ___                               _ _     _           _                          _                       
     |_ _|_ __ ___  _ __   ___  ___ ___(_) |__ | | ___     / \   _ __   ___   ___ __ _| |_   _ _ __  ___  ___  
      | || '_ ` _ \| '_ \ / _ \/ __/ __| | '_ \| |/ _ \   / _ \ | '_ \ / _ \ / __/ _` | | | | | '_ \/ __|/ _ \ 
      | || | | | | | |_) | (_) \__ \__ \ | |_) | |  __/  / ___ \| |_) | (_) | (_| (_| | | |_| | |_) \__ \  __/ 
     |___|_| |_| |_| .__/ \___/|___/___/_|_.__/|_|\___| /_/   \_\ .__/ \___/ \___\__,_|_|\__, | .__/|___/\___| 
                   |_|                                          |_|                      |___/|_|              ";


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(logo);
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void ChapterOneText()
        {
            string chapterOne = @"
       ____ _                 _              _ 
      / ___| |__   __ _ _ __ | |_ ___ _ __  / |
     | |   | '_ \ / _` | '_ \| __/ _ \ '__| | |
     | |___| | | | (_| | |_) | ||  __/ |    | |
      \____|_| |_|\__,_| .__/ \__\___|_|    |_|
                       |_|                     ";

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(chapterOne);
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void CampFire()
        {
            string campFire = @"
                        )(          
                       (  (         
                       )   )        
                     (    (       
                      ) /\ )
                    (  // | (`'     
                  _ -.;_/ \\--._    
                 (_;-// | \ \-'.\   
                 ( `.__ _  ___,')   
                  `'(_ )_)(_)_)'";

            Console.WriteLine(campFire);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
