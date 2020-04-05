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

        public static void GameOver()
        {
            string youDied = @"
                                        __   _____  _   _   ____ ___ _____ ____  
                                        \ \ / / _ \| | | | |  _ \_ _| ____|  _ \ 
                                         \ V / | | | | | | | | | | ||  _| | | | |
                                          | || |_| | |_| | | |_| | || |___| |_| |
                                          |_| \___/ \___/  |____/___|_____|____/ ";

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(youDied);
            Console.WriteLine();
            Skull();
            Console.ResetColor();
        }

        private static void Skull()
        {
            string skull = @" 

                                                        MNddhdmN
                                                     ho/+-+.....+/sm
                                                  y/....|----+.++.``+o
                                                h+`...+--+.|-----+...``+
                                               o.``.+---+..+---------+...d
                                               :++:://:::::::++:+-+:::+--+m
                                               ::/+-+////////::::+:::::+::+
                                               +/+-+//:///////::::+::::://:
                                               s+//+-+//::///////::::+:/++/
                                               s+/+sydddhyoososssooo/++:oo+
                                               syhdNNNNNmdhsssomNNNNNmy++os
                                               shmmNNMMMMms/:+oNMMNNmmdy:/h
                                               oodmNNMMNNsooo:+hNNNmmmh+::y
                                               --+syhhysooyNNy::+sysso/:::+
                                               yyyhyyyyysymMMMs/oooooo+///+
                                               hhddmmmhysdMMMMm/++ohsyss/sN
                                                yhmMNdhssshdyy+:::/omN+/d
                                                yydNMdhssssss/|:::/sNs/o
                                                mhhmNmhhhyyos++////hd//h
                                                Mhyhddyssysos:/+/::so//h
                                                 dyo+oyhyyhhyssh+/////+
                                                  dyssyyhddyhsso+/+//o
                                                    hsyyhhyysso////+d
                                                      mhyyyyso+//od";

            Console.WriteLine(skull);
            Console.WriteLine();
        }
    }
}
