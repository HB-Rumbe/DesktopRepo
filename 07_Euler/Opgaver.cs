// https://projecteuler.net/archives

using System.Numerics;
public static class ProjectEuler
{
    public static void ID1()
    {

        int sum = 0;

        for (int i = 1; i < 1000; i++)
        {
            int same = 0;
            if (i % 3 == 0)
            {
                same += i;
                Console.Write(i + " ");
                sum += i;
            }
            if (i % 5 == 0)
            {
                if (same == i)
                { }
                else
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }
        }
        Console.WriteLine($"\nThe sum is {sum}");
    }
    public static void ID2()
    {
        // ID 2

        int f1 = 1;
        int f2 = 1;
        int f3 = 2;
        int f4 = 3;
        double goldenratio = 1.61803398875;
        double fib;
        double sum = f3;
        Console.Write(f1 + "\n" + f2 + "\n" + f3 + "\n" + f4 + "\n");


        for (double i = 3; i < 4000000;)
        {
            fib = Math.Round(i * goldenratio);
            i = fib;
            if (i % 2 == 0)
            {
                sum += fib;
                Console.WriteLine(fib);
            }

        }
        Console.WriteLine($"This is the sum {sum}");
    }
    public static void ID3()
    {
        // ID 3
        int count = 0;


        Console.Clear();
        Console.WriteLine("Which number would you like to check?");
        long number = Convert.ToInt64(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("These are prime factors:");


        for (int i = 2; 1 < number; i++)
        {
            if (number % i == 0)
            {

                while (number % i == 0)
                {
                    number /= i;
                    count++;
                    Console.Write(i + " ");
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine($"There are {count} prime factors.");
        Console.ReadLine();
    }
    public static void ID4()
    {
        //ID 4
        for (int i = 999; i > 100; i--)
        {
            for (int j = 999; j > 100; j--)
            {
                int reverse = 0;
                int num = i * j;

                while (num > 0)
                {
                    int remainder = num % 10;
                    reverse = (reverse * 10) + remainder;
                    num = num / 10;
                }
                num = i * j;
                if (reverse == num)
                {
                    Console.WriteLine($"{num} = {i} X {j}");
                }
            }
        }
    }
    public static void ID5()
    {
        // ID 5


        for (int i = 20; i > 0; i++)
        {
            bool evenly = true;
            for (int j = 1; j < 21; j++)
            {
                if (i % j != 0)
                {
                    evenly = false;
                }

            }
            if (evenly)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
    public static void ID6()
    {
        //ID 6

        double sq = 0;
        double naturalsum = 0;
        double naturalsumsq = 0;
        double answer = 0;

        for (int i = 1; i <= 100; i++)
        {
            sq += Math.Pow(i, 2);
            naturalsum += i;
        }
        naturalsumsq = Math.Pow(naturalsum, 2);
        answer = naturalsumsq - sq;
        Console.WriteLine(answer);
    }
    public static void ID7()
    {
        //ID 7


        int count = 0;
        int term = 0;
        for (int i = 2; i < 40000000; i++)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
                if (count > 1)
                {
                    break;
                }

            }

            if (count < 1)
            {
                Console.WriteLine(i);
                term += 1;

            }
            count = 0;
            if (term == 10001)
            {
                Console.WriteLine($"The 10001 term is {i}");
                break;
            }

        }
    }
    public static void ID8()
    {
        // ID 8

        String digits = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        long sum = 0;
        long highestnumber = 0;
        for (int i = 0; i < 987; i++)
        {
            sum = 1;
            string substring1 = digits.Substring(i, 13);
            for (int j = 0; j < 13; j++)
            {

                long substring2 = Convert.ToInt64(substring1.Substring(j, 1));
                sum *= substring2;
            }
            Console.WriteLine(sum);
            if (sum != 0)
            {
                if (sum > highestnumber)
                {
                    highestnumber = sum;
                }
            }
        }
        Console.WriteLine(highestnumber);
    }
    public static void ID9()
    {
        // ID 9

        double c = 0;

        for (double a = 1; true; a++)
        {
            for (double b = a + 1; b < 1000; b++)
            {
                c = Math.Pow(a, 2) + Math.Pow(b, 2);

                if (a < b && b < Math.Round(Math.Sqrt(c)) && Math.Sqrt(c) % 1 == 0 && Math.Sqrt(c) + a + b == 1000)
                {
                    Console.WriteLine($"{a} + {b} + {Math.Sqrt(c)} = {a + b + Math.Sqrt(c)}");
                    Console.WriteLine(a * b * Math.Sqrt(c));
                    return;
                }
            }
        }
    }
    public static void ID10()
    {
        // ID 10

        int count = 0;
        long sum = 0;

        for (int i = 2000000; i > 1; i--)
        {
            for (int j = 2; j < Math.Round(Math.Sqrt(i)) + 1; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
                if (count > 1)
                {
                    break;
                }
            }
            if (count < 1)
            {
                sum += i;
            }
            count = 0;
        }
        Console.WriteLine(sum);
    }
    public static void ID11()
    {
        // ID 11

        List<List<int>> grid = new List<List<int>>{

        new List<int>{ 08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08 },
        new List<int>{ 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00 },
        new List<int>{ 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65 },
        new List<int>{ 52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91 },
        new List<int>{ 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80 },
        new List<int>{ 24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50 },
        new List<int>{ 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70 },
        new List<int>{ 67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21 },
        new List<int>{ 24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72 },
        new List<int>{ 21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95 },
        new List<int>{ 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92 },
        new List<int>{ 16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57 },
        new List<int>{ 86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58 },
        new List<int>{ 19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40 },
        new List<int>{ 04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66 },
        new List<int>{ 88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69 },
        new List<int>{ 04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36 },
        new List<int>{ 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16 },
        new List<int>{ 20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54 },
        new List<int>{ 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48 }};

        int largestnumber = 0;
        int sum = 0;
        for (int i = 0; i < 20; i++)
        {
            for (int x = 0; x < 17; x++)
            {
                sum = grid[i][x] * grid[i][x + 1] * grid[i][x + 2] * grid[i][x + 3];

                if (sum > largestnumber)
                {
                    largestnumber = sum;
                }
            }

        }


        for (int i = 0; i < 20; i++)
        {
            for (int x = 0; x < 17; x++)
            {
                sum = grid[x][i] * grid[x + 1][i] * grid[x + 2][i] * grid[x + 3][i];


                if (sum > largestnumber)
                {
                    largestnumber = sum;
                }

            }

        }
        for (int i = 0; i < 17; i++)
        {
            for (int x = 0; x < 17; x++)
            {
                sum = grid[i][x] * grid[i + 1][x + 1] * grid[i + 2][x + 2] * grid[i + 3][x + 3];

                if (sum > largestnumber)
                {
                    largestnumber = sum;
                }

            }

        }
        for (int i = 0; i < 17; i++)
        {
            for (int x = 0; x < 17; x++)
            {
                sum = grid[i][x + 3] * grid[i + 1][x + 2] * grid[i + 2][x + 1] * grid[i + 3][x];

                if (sum > largestnumber)
                {
                    largestnumber = sum;
                }

            }

        }

        Console.WriteLine(largestnumber);
    }
    public static void ID12()
    {
        // ID 12

        long sum = 0;
        for (long i = 1; i > 0; i++)
        {
            sum += i;
            int count = 0;
            for (long j = 1; j * j <= sum; j++)
            {

                if (sum % j == 0)
                {
                    count += 2;
                    if (j * j == sum)
                    {
                        count--;
                    }
                }

            }
            if (count > 500)
            {
                Console.WriteLine(sum);
                Console.WriteLine(count);
                Console.WriteLine(i);
                return;
            }
        }
    }
    public static void ID13()
    {
        // ID 13

        string number = "37107287533902102798797998220837590246510135740250463769376774900097126481248969700780504170182605387432498619952474105947423330951305812372661730962991942213363574161572522430563301811072406154908250230675882075393461711719803104210475137780632466768926167069662363382013637841838368417873436172675728112879812849979408065481931592621691275889832738442742289174325203219235894228767964876702721893184745144573600130643909116721685684458871160315327670386486105843025439939619828917593665686757934951621764571418565606295021572231965867550793241933316490635246274190492910143244581382266334794475817892575867718337217661963751590579239728245598838407582035653253593990084026335689488301894586282278288018119938482628201427819413994056758715117009439035398664372827112653829987240784473053190104293586865155060062958648615320752733719591914205172558297169388870771546649911559348760353292171497005693854370070576826684624621495650076471787294438377604532826541087568284431911906346940378552177792951453612327252500029607107508256381565671088525835072145876576172410976447339110607218265236877223636045174237069058518606604482076212098132878607339694128114266041808683061932846081119106155694051268969251934325451728388641918047049293215058642563049483624672216484350762017279180399446930047329563406911573244438690812579451408905770622942919710792820955037687525678773091862540744969844508330393682126183363848253301546861961243487676812975343759465158038628759287849020152168555482871720121925776695478182833757993103614740356856449095527097864797581167263201004368978425535399209318374414978068609844840309812907779179908821879532736447567559084803087086987551392711854517078544161852424320693150332599594068957565367821070749269665376763262354472106979395067965269474259770973916669376304263398708541052684708299085211399427365734116182760315001271653786073615010808570091499395125570281987460043753582903531743471732693212357815498262974255273730794953759765105305946966067683156574377167401875275889028025717332296191766687138199318110487701902712526768027607800301367868099252546340106163286652636270218540497705585629946580636237993140746255962240744869082311749777923654662572469233228109171419143028819710328859780666976089293863828502533340334413065578016127815921815005561868836468420090470230530811728164304876237919698424872550366387845831148769693215490281042402013833512446218144177347063783299490636259666498587618221225225512486764533677201869716985443124195724099139590089523100588229554825530026352078153229679624948164195386821877476085327132285723110424803456124867697064507995236377742425354112916842768655389262050249103265729672370191327572567528565324825826546309220705859652229798860272258331913126375147341994889534765745501184957014548792889848568277260777137214037988797153829820378303147352772158034814451349137322665138134829543829199918180278916522431027392251122869539409579530664052326325380441000596549391598795936352974615218550237130764225512118369380358038858490341698116222072977186158236678424689157993532961922624679571944012690438771072750481023908955235974572318970677254791506150550495392297953090112996751986188088225875314529584099251203829009407770775672113067397083047244838165338735023408456470580773088295917476714036319800818712901187549131054712658197623331044818386269515456334926366572897563400500428462801835170705278318394258821455212272512503275512160354698120058176216521282765275169129689778932238195734329339946437501907836945765883352399886755061649651847751807381688378610915273579297013376217784275219262340194239963916804498399317331273132924185707147349566916674687634660915035914677504995186714302352196288948901024233251169136196266227326746080059154747183079839286853520694694454072476841822524674417161514036427982273348055556214818971426179103425986472045168939894221798260880768528778364618279934631376775430780936333301898264209010848802521674670883215120185883543223812876952786713296124747824645386369930090493103636197638780396218407357239979422340623539380833965132740801111666627891981488087797941876876144230030984490851411606618262936828367647447792391803351109890697907148578694408955299065364044742557608365997664579509666024396409905389607120198219976047599490197230297649139826800329731560371200413779037855660850892521673093931987275027546890690370753941304265231501194809377245048795150954100921645863754710598436791786391670211874924319957006419179697775990283006991536871371193661495281130587638027841075444973307840789923115535562561142322423255033685442488917353448899115014406480203690680639606723221932041495354150312888033953605329934036800697771065056663195481234880673210146739058568557934581403627822703280826165707739483275922328459417065250945123252306082291880205877731971983945018088807242966198081119777158542502016545090413245809786882778948721859617721078384350691861554356628840622574736922845095162084960398013400172393067166682355524525280460972253503534226472524250874054075591789781264330331690";

        double sum = 0;
        for (int i = 0; i < 4970; i += 50)
        {
            double start3 = Convert.ToDouble(number.Substring(i, 50));
            Console.WriteLine(i);
            Console.WriteLine(start3);
            sum += start3;

        }
        Console.WriteLine(sum);
    }
    public static void ID14()
    {
        // ID 14

        long highestnumber = 0;
        long highestnumb = 0;
        long hold = 0;


        for (long i = 3; i < 1000000; i++)
        {
            hold = i;
            int count = 0;


            while (hold > 2)
            {

                if (hold % 2 == 0)
                {
                    hold /= 2;
                    count++;

                }
                if (hold % 2 != 0)
                {
                    hold *= 3;
                    hold += 1;
                    count++;

                }
            }

            if (count > highestnumber)
            {
                highestnumber = count;
                highestnumb = i;
            }


        }
        Console.WriteLine(highestnumber);
        Console.WriteLine(highestnumb);
    }
    public static void ID15()
    {
        //ID 15
        // https://stemhash.com/counting-lattice-paths/


        int term = Convert.ToInt32(Console.ReadLine());
        double num = 1;
        double largestnumber = 0;
        Console.Clear();

        for (double i = 0; i <= term; i++)
        {
            for (double j = 0; j <= i; j++)
            {
                if (i == 0 || j == 0)
                {
                    num = 1;

                }
                else
                {
                    num = num * (i - j + 1) / j;
                }
                if (num > largestnumber)
                {
                    largestnumber = num;
                }
                Console.Write(num + " ");

            }
            Console.Write("\n");

        }
        Console.WriteLine("---------------------------");
        Console.WriteLine(largestnumber);
    }
    public static void ID16()
    {
        BigInteger powersum = BigInteger.Pow(2, 1000);

        string KD = Convert.ToString(powersum);
        int sum = 0;

        for (int i = 0; i < KD.Length; i++)
        {
            sum += Convert.ToInt32(KD.Substring(i, 1));
        }

        Console.WriteLine(sum);



    }
    public static void ID17()
    {
        string one = "one";
        string two = "two";
        string three = "three";
        string four = "four";
        string five = "five";
        string six = "six";
        string seven = "seven";
        string eight = "eight";
        string nine = "nine";
        string ten = "ten";
        string eleven = "eleven";
        string twelve = "twelve";
        string thirteen = "thirteen";
        string fourteen = "fourteen";
        string fifteen = "fifteen";
        string sixteen = "sixteen";
        string seventeen = "seventeen";
        string eighteen = "eighteen";
        string nineteen = "nineteen";
        string twenty = "twenty";
        string thirty = "thirty";
        string forty = "forty";
        string fifty = "fifty";
        string sixty = "sixty";
        string seventy = "seventy";
        string eighty = "eighty";
        string ninety = "ninety";
        string onehundred = "onehundredand";
        string twohundred = "twohundredand";
        string threehundred = "threehundredand";
        string fourhundred = "fourhundredand";
        string fivehundred = "fivehundredand";
        string sixhundred = "sixhundredand";
        string sevenhundred = "sevenhundredand";
        string eighthundred = "eighthundredand";
        string ninehundred = "ninehundredand";
        string onetousand = "onetousand";

        string onetonine = one + two + three + four + five + six + seven + eight + nine;
        string onetonineteen = one + two + three + four + five + six + seven + eight + nine + ten + eleven + twelve + thirteen + fourteen + fifteen + sixteen + seventeen + eighteen + nineteen;
        string alltens = twenty + thirty + forty + fifty + sixty + seventy + eighty + ninety;
        string hundreds = onehundred + twohundred + threehundred + fourhundred + fivehundred + sixhundred + sevenhundred + eighthundred + ninehundred;
        string hundredswithoutand = "onehundredtwohundredthreehundredfourhundredfivehundredandsixhundredsevenhundredeighthundredninehundred";
        int sum = 0;
        int sum2 = 0;
        int sum3 = 0;
        int sum4 = 0;

        //one to nine between 20 and 80 in all the hundreds
        for (int i = 0; i < 10; i++)
        {
            sum += Convert.ToInt32(onetonine.Length) * 8;
        }
        //one to nineteen all ten times
        for (int i = 0; i < 10; i++)
        {
            sum2 += Convert.ToInt32(onetonineteen.Length);
        }
        //twenty, thithy etc. all 100 times.
        for (int i = 0; i < 9; i++)
        {
            sum3 += Convert.ToInt32(alltens.Length) * 100;
        }
        //The hundreds
        for (int i = 0; i < 9; i++)
        {
            sum4 += ((Convert.ToInt32(hundreds.Length) * 10) - 27);
        }




        Console.WriteLine(onetonine);
        Console.WriteLine(onetonineteen);
        Console.WriteLine(sum);
        Console.WriteLine(sum2);
        Console.WriteLine(sum3);
        Console.WriteLine(sum4);
        Console.WriteLine(sum + sum2 + sum3 + sum4 + onetousand.Length);

    }
    public static void ID18()
    {
        Console.Clear();

        List<List<int>> grid = new List<List<int>>{

        new List<int>{04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23},
        new List<int>{63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
        new List<int>{91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
        new List<int>{70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
        new List<int>{53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
        new List<int>{41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
        new List<int>{41, 41, 26, 56, 83, 40, 80, 70, 33},
        new List<int>{99, 65, 04, 28, 06, 16, 70, 92},
        new List<int>{88, 02, 77, 73, 07, 63, 67},
        new List<int>{19, 01, 23, 75, 03, 34},
        new List<int>{20, 04, 82, 47, 65},
        new List<int>{18, 35, 87, 10},
        new List<int>{17, 47, 82},
        new List<int>{95, 64},
        new List<int>{75}};

        // grid[2][1] = 47
        // grid[2][2] = 82
        // grid[3][2] = 87

        for (int i = 0; i <= 14; i++)
        {
            for (int j = 0; j < 15 - i; j++)
            {
                Console.Write(grid[i][j] + " ");
            }
            Console.WriteLine();
        }



    }
    public static void ID20()
    {
        // ID 20

        BigInteger sum = 1;
        int digitcount = 0;
        int digitsum = 0;

        for (int i = 100; i > 0; i--)
        {
            sum *= i;
        }
        string numstring = Convert.ToString(sum);
        Console.WriteLine(numstring);

        foreach (char a in numstring)
        {
            Console.WriteLine(numstring.Substring(digitcount, 1));
            digitsum += Convert.ToInt16(numstring.Substring(digitcount, 1));
            digitcount++;
        }
        Console.WriteLine(digitsum);
    }
    public static void ID21()
    {
        List<int> numbers = new List<int>();

        for (int i = 1; i < 10000; i++)
        {
            int sum = 0;
            for (int j = 1; j < i; j++)
            {

                if (i % j == 0)
                {
                    sum += j;
                }
            }
            numbers.Add(sum);
        }

        int sum2 = 0;
        for (int i = 1; i < 9999; i++)
        {
            int sumofi = numbers[i];
            if (sumofi < 10000 && sumofi - 1 < numbers.Count && sumofi != i + 1 && numbers[sumofi - 1] == i + 1)
            {
                sum2 += i + 1 + sumofi;

            }

        }


        Console.WriteLine(sum2);


    }
    public static void ID25()
    {
        // ID 25


        BigInteger fibnum = 3;
        BigInteger fibnum2 = 5;
        BigInteger sum;
        int digitnum = 0;
        int iteration = 5;

        for (int i = 0; digitnum != 1000; i++)
        {
            digitnum = 0;
            sum = fibnum + fibnum2;
            fibnum = fibnum2;
            fibnum2 = sum;

            iteration++;
            string fibstring = Convert.ToString(sum);
            foreach (char a in fibstring)
            {
                digitnum++;
            }
        }

        Console.WriteLine(iteration);
    }
 
    public static void ID26()
    {
        BigInteger test = 1;
        BigInteger test2 = 1;
        BigInteger sum = 0;
        for(int i = 0; i <101; i++)
        {
            sum = BigInteger.Divide(test,test2);
            Console.WriteLine(sum);
            test2++;
        }


    }
    public static void ID29()
    {
        // ID 29

        int number = 0;
        List<string> numbers = new List<string>();


        for (double i = 2; i <= 100; i++)
        {
            for (double power = 2; power <= 100; power++)
            {
                numbers.Add(Convert.ToString(Math.Pow(i, power)));
                number++;



            }
        }

        // Hashset har acceptere kun unikke numre.
        var uniquenumbers = new HashSet<string>(numbers);

        int count = uniquenumbers.Count;
        Console.WriteLine(count);


    }
    public static void ID48()
    {

        BigInteger sum = 1;
        int power = 2;
        for (BigInteger i = 2; i <= 1000; i++)
        {
            sum = BigInteger.Add(BigInteger.Pow(i, power), sum);
            power++;
        }
        Console.WriteLine(sum % 10000000000);

    }





}