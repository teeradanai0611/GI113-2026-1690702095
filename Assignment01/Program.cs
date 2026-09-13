/*
 * Student ID : 1690702095
 * Name       : Assignment01
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "QUESTISM";

            string charName = "ICQ";
            char charRank = 'X';

            int health = 100;
            float tacticalCooldown = 25.5f;
            double movementSpeed = 7.5;
            bool isAlive = true;

            var charClass = "Assassin";
            var charSymbol = '†';

            double convertedHealth = health;
            int castCooldown = (int)tacticalCooldown;
            int convertCooldown = Convert.ToInt32(tacticalCooldown);
            string titleArt = @"                                                                                                                                                  
                                                                                                                                                  
                                                                                                                                                  
                                                                                                                                                  
                                                                               x                                                                  
                                                                               +                                                                  
                                                                               +                                                                  
                                  +x                             x+           xx                                   +++                            
                                 +x+                                          x+                                                                  
                              +xxxxx+x                           x           xxxx                                                                 
                      xx   x++++++xxxx+++                      x+          +xxxxxxxx+xxxx+xxx+xxx+x+++x+xx+x+                                     
                      xx+xx+xx+    ++xxx++x+                 +x     xx  +xx++xx+x++++                      xx+xx++x+x+     xxx                    
                     xx+xx+xx         xxxxxx++x  ++xx    x+x+      xxx++xx  +x+x+x    xx                   x +xxxx+       +xxxxxx                 
               x++xxxxxxx++x           ++xx++   x+   x+xxx+x+ +x++x         x+xx+x               x+    +++xx+xxx++x+  ++++xxxxx                   
          +++x+xxxx+xxxxxx+x           +xxx++x+++xxx  xxxx++x++x+xx++xx xxxxx+x+x+x+x+xxx+x++x+x++x+ +xx+x+xxx xx+x+    x+xxxxx                   
              +x++x+++xxx+++           xxxxxx+x+x++    +xxx +xxxx+xx+x  +xx   ++xx+++++xxxxx+xxx+xx xxx+    +  xxxxx    ++xxxxx                   
            xxx+    +x+xxxx            +x+xxxxxx+++    xxx+ xx++       xxxxx xx+x     xxxx     xxxx xx+++      x+xx+x  +xxxxx+++                  
          +x+x+     x+xxxxx            xxxxxx++x+x+    xx+x xxx+xxxx    x+xx++x+      ++xx     xxxx  +x+xxxx+  xx++x+  xxxxxxxx  x+               
         +  +x      x+xxxx+            x+xx+xxxx+x+    +x+x xx+xxxxx      x++x+x+x    xxx+     xx++     ++xx+x+xxx+x+xxxxxx+xx+ x++ +xxx++        
            +xx     x+xxxxx            xxxxxx +x+xx    +xxx +x++   x         x+x+++   +xxx     x+x+       +xxxxx+x++xx++xx xxx+x+++xx+++          
             xx+xx  +x+xxxxx  xxxxx+x++xxxxxx x+xx+    xxxx xxx+       +     xxxx+x   xxxx     xxxx +x     +x+++++ xxxx++  ++xx+    xx+           
                +++  x++xxxx     +x+xxxxx+xx   xx++    +x+x +x+x    ++x x++  +x+xx    ++x+     ++xx x++   +xxx+x++  +++++  x+x++ x+x              
                 xx+  +xxxx++      x++x+x+     xx+xx+x++++ xxx+x+xxxxxx +x++x+xxx    +xxxx     xxx+xxxx++x+++xx+++  xx+x   +xxx+x                 
                   ++xxxxxxxxx++ xxxx+xxxx+x+    x+xxx++  xxx++x+++xxx x+x   +xx    +xxx++xx  x++xx+  xx+xx+  xxx+   +x+   ++xx++                 
                    +x +xxx+xxxxxxx++x+++xxx++x           x+        xxx      +xx           x+x     xx+       xxxx+    x    x+xxx++                
                   +x+  xx+xxxxxx+++xx+ x++xxx+x++xx+++xx+x       +          x+x          x+          +x+    x+xxx+  x+x    xxxxxx                
                       xx+     xxx         ++xx+++x    +  +x+++ xx           +xx                +xxx+++++xxx+xx+       x+xx++xxx+++               
                    x++      xx +x+x+++x+xx++++x+xxx+x       ++xx+  +         +x       +++x+x     x+x     xxx      +x++x++x++x++++xx              
                   xx             xx++     xx   xx++x+x+x      +x+xxxx+++++   +x     xx++                ++                 xxx +x+++x            
                                                    +x+++xxx            +x+x+x+xxx+xx                                               +xx           
                                         x++                  +              +x+                                                       x          
                                         x                                    xx                                                                  
                                                                              x+                                                                  
                                                                              x                                                                   
                                                                                                                                                  
                                                                                                                                                  
                                                                                                                                                  
                                                                                                                                                  
                                                                                                                                                  ";
            Console.WriteLine(titleArt);
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(" ╔════════════════════════════════════════════════════╗");
            Console.WriteLine($" ║                      {GameTitle}                      ║");
            Console.WriteLine(" ║                                                    ║");
            Console.WriteLine($" ║                     │ [{charSymbol}] {charName} │                    ║");
            Console.WriteLine(" ║                                                    ║");
            Console.WriteLine($" ║                      {charClass}                      ║");
            Console.WriteLine(" ║                                                    ║");
            Console.WriteLine(" ╠════════════════════════════════════════════════════╣");
            Console.WriteLine(" ║                   PLAYER PROFILE                   ║");
            Console.WriteLine(" ╠════════════════════════════════════════════════════╣");
            Console.WriteLine(" ║                                                    ║");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" ║    PLAYER NAME : {charName}                               ║");
            Console.WriteLine($" ║    CLASS       : {charClass}                          ║");
            Console.WriteLine($" ║    PLAYER CODE : {charSymbol}                                 ║");
            Console.WriteLine($" ║    RANK        : {charRank}                                 ║");
            Console.WriteLine($" ║    ALIVE       : {isAlive}                              ║");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine(" ║                                                    ║");
            Console.WriteLine(" ╠════════════════════════════════════════════════════╣");
            Console.WriteLine(" ║                     COMBAT DATA                    ║");
            Console.WriteLine(" ╠════════════════════════════════════════════════════╣");
            Console.WriteLine(" ║                                                    ║");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" ║  HEALTH         : {health} Hp                           ║");
            Console.WriteLine($" ║  MOVEMENT SPEED : {movementSpeed}                              ║");
            Console.WriteLine($" ║  TACTICAL CD    : {tacticalCooldown} Sec                         ║");
            Console.WriteLine(" ║                                                    ║");
            Console.WriteLine(" ║  HEALTH STATUS                                     ║");
            Console.WriteLine(" ║                                                    ║");
            Console.WriteLine(" ║  [████████████████████████████]                    ║");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ║                                                    ║");
            Console.WriteLine(" ╠════════════════════════════════════════════════════╣");
            Console.WriteLine(" ║                    ABILITY PANEL                   ║");
            Console.WriteLine(" ╠════════════════════════════════════════════════════╣");
            Console.WriteLine(" ║                                                    ║");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(" ║    TACTICAL : SHADOW STEP                          ║");
            Console.WriteLine($" ║    COOLDOWN : {tacticalCooldown} Second                          ║");
            Console.WriteLine(" ║                                                    ║");
            Console.WriteLine($" ║    SYSTEM A CD : {castCooldown} Second                         ║");
            Console.WriteLine(" ║                                                    ║");
            Console.WriteLine($" ║    SYSTEM B CD : {convertCooldown} Second                         ║");
            Console.WriteLine(" ║                                                    ║");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine(" ╠════════════════════════════════════════════════════╣");
            Console.WriteLine(" ║                 PLAYER STATUS : ???                ║");
            Console.WriteLine(" ╚════════════════════════════════════════════════════╝");

            Console.ResetColor();
            Console.WriteLine();

            string playerArt = @"xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx+++;;;;:::::::;;;::..:;;;+++++++&&&;;;;;;;;+++++xxxxxxxxxxxxxxxxxx++
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx+++;;;;;;;;;;;;;;;;:::::;++++++++&&+;;;;;;;+++++++xxxxxxxxxxxxxxx++++
XXXXXXXXXXxXxXXXXXXXXxxxxxxxxxx+++++++++;;;;;;;;;;;;::::;+xXXxx++XX++;;;;;;++++++xxxxxxxxxxxxxxxxx++;
XXXXXXXXXXXXXXXXXXXXXXXXxxxxxxx++++++++x;;.:;;;;;;;;;:::;+&&&&$x++++++;;;;;+++++xxxxxxxxxxxxxxxx+x+;;
XXXXXXXXXXXXXXXXXXXXXXXXxxxxxxxxxx++++xx: :;;+++;;;  .:::x&&&&&&x++++++;;;+++++xxxxxxxxxxxxxxxx+++;;:
XXXXXXXXXXXXXXXXXXXXXXXXxxxxxxxxxx.++++;      .        ::+$&&&&&x+++++++;;++++xxxxxxxxxxXXXXxx+++;;::
XXXXXXXXXXXXXXXXXXXXXXXXxxxxxxxxx+ .: .                 .  .;$&X+;;;;+++;;;++++xxxxxxxxXXXXXx++;;::::
XXXXXXXXXXXXXXXXXXXXXXXxXXXXXXxxx+   :+:  ..               :+xx++;;::;;;;;;+++++xxxxxxxXXXXxx+;;::::.
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXxxx;       .:       .        ;;+++++;;::;;;;;;+++++xxxxxXXXX+++;::::...
XXXXXXXXXXXXXXXXXXXXX$$$$$$XXXxxx+       ..               ..:;++xx++;:.::::;+++++xxxxxXXx++;;;:::... 
XXXXXXXXXXXXXXX$$X$$$&&&&$$$XXxxx++                    .     ;++xxXx;::..:::;++++++xxxxx+;:::::....  
XXXXXXXXXXXXX$$$$$$&&&&&$$$XXxxx+.                    .      :;++xxx+;::...:;++++xxxxxx++:::::....   
XXXXXXXXXXX$$&$$$$&&&&&$XXxxxxx+.        .          .        ;;+++x+++;;::..:;++xxxxxx+;::::......   
XXXXXXXXXX$$$&$$&&&&&$XXxx+++x+;.                            .+++++++;+;;::.::;+xxxXXx;:::......     
$$xXXXXX$X$$$$&$&&&$$Xxx++++++;;: :    .                      ++++++++;;;;;:::;+xxXXxx:::......   . .
$$$$XXXXX$$$$$$$$$$$Xxxx+++;;;;;.           .        :       ;+++++++++;;;;;;;;;+xxX+:::...... ...   
$$$XXXXXXX$$$$$$$$XXXxxx++++++++;;:..   .   .               :;;++++++++;;;;;;;;;;+x;:::..... ....    
xXXXXXXXXXXX$$$XXXXXXXxxx+xxxxxx+::.:+..  :++.     .;+: .  .++;;;;++++;;;;;:;;;;;;::::..... ....     
$$XXXXXXXXXX$$$XxXXX$XXXxxxXXXXx+;::.:. ;:.;+;.:   ;+;;;; :;;;;;;;;;;++;;;;::;;;;:....... ....     :X
$$XXXXXXXXXX$$$XXxxX$$XXxxxXX$&XX+::::..; .;;;;;:;:;;;;;.. .;;;;;+;;;;;;;;;::;;;...:+++;;+;.      x;X
$$$XXXXXXXX$$$$XXxxXXXXXx+;+xX&&$X+;:..:   ;;;;;:;;;;;;; ..;::;;;++;;;;;;;;:;;:..;X$&$$$$x.   . +.XXX
$$$XXXXXXXX$&&&$XXxxxxxx++;;+x$&$x;::....  .;;;;:;;;;;; ;;;;;::;;;;;;;;;;;;:;...:X$&&$&Xx.    :.XXXXX
XX$$XXXXXX$$&&&$XXxxxx++++......::..      .:;;;;;;;;;;.:;;;;::::;;;;;;;;;;;:...:;x+++::.     .XXXXXXX
XXXXXXXX$$$$&&&&$Xxxxx++:  ........         ;;;::;;;      ;;;;;::;;;;;;;;:...........   .  ;XXXXXXXXX
XXXXXXX$$$$$&&&&+Xxxxxxx . ........           ;;;;    .      :;;:;;;;;;:....... .....    ;XXXXXXXX:$X
XXXXX$$$$$$$&&&&&XxxxXX... .......                   .:          ;;;+;.............. ..:;XXXXXXXXXX$$
XXXX$$$$$$$$$&&&&$Xxxxx..........  .       ...      :.;:   .      ;;:               .xX$XXXXXXXXXX$X&
XXXX$$XXX$$$$$$&&&$Xxxx........       .  ...;.    .;:;;;;      .     . .       .  ..:;x$XXXXXXXXX$$$$
XXX$$XXXX$$XXXXX$$$$XxxX;.... .         . ..;....:;;:;;;;;;                   ...:::.;+X$XXXXXXX$$$$$
$X$$XXXXXXXXxxXxXXXXXXXX.X:..              .:;.;;;;;;;;;;;;. ....  .         .;::::::;+xXXXXXXXX$$$$$
$$$$XXXXXXXXxxxx++xxxX$$+xX;            ....:;;:;;;;:;;;;;:. .....        .++;;;::;::;+xXXXX$$XX$$$$$
$$$$XXXXXXXx+. .+xxxxXX$$..         .    ;;;;..;;:.;;;;;;:;. ......     .+++++;;;;;+;;+xXXXX$$XXX$$$$
$$$$XxXXXXxx.  .+++xxX+:..                ;;;;;;;;:;.:;++;;:  .....        :++++;+++++xXXXXX$XXXXXXXX
$$$XXxxxxxx+    :+++..:..           .    .:::;;;;;;;;;;:....  ..:...       . :++++xxxxxXXXXXXXXXXXXXX
$$$XXxxxxx++.     ......  .                ....:;;;;;:.....:   .....       ....+xxXXXXxXXXXXXXXXXXXXX
$$XXXxxxx+;;;. .   .....                      ;;;;;:.....:+;   .......  .  .....X$$$XxxxXXXXXXXXXXXX$
$$XXXx++++;:;;;;.  ....              .    .:. .;;.....:++++:     .....    . ....:&&XxxxxXXXXXXXXXX$$$
$$XxXx+++;;:::;;   ....     .          .;;++++....:;++++++:.       .....     ....X$XxxxxXXXXXXXX$$$$$
XXxxxx++;;;::;..  .....      .     .    ;+++:..;+++++++++:::         ...    .....;XXxxxxXXXXX$$$$$$$$
XXxxxx+;;;;:;;;.. .....        .        .+:;++.+++++++++:::.     .  . . ........  xXXXXXXXX$$$$$$$$$$
Xxxxxx+;;;;;;;: .......         .  .;++: ;+x+:++++xxxx+:..:+.       .     ....    .XXXXXXXX$$$$$$$$$$
Xxxxxx+++;;:::.    ....     .       ++:++:++xxxxxxxxxx:..;++ .                    .+xxXXXXXXX$$$$$$$$
xxxxxx+++;;::.      ...             ++;+++xxxxxxxxxxx:.:++++          .            ;+xxxXXXXXXXX$$$$X
xxxxxx+++;;::.      .     ..        +++++;+xxxxxxxx;::xxxx++          .            .;+xxxXXXXXXXXXXXX
+xxxx++++;:::                   .  .++++xxxxxxxxx+:;xxxxxx++. . . .             .   :;+xxXXXXXXXXXXXX
+xxx+++++;::.       .              .++xxxxxxxxx+;+xxxxxxxx++.                        ;;+xxXXXXXXXXXXX
+xxx+++++;::.      .    .        . .++xxxxxx++;xxxxxxxxxxx++.   .  .   .              ;++xXXXXXXXXXXX
xxxxx+++;:::.             .        :+xxxxx+;;+xxxxxxxxxxx+++:                         +++xxXXXxXXXXXX
";
            Console.WriteLine(playerArt);

        }
    }
}
