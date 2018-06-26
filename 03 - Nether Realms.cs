namespace _03_NetherRealms
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class NetherRealmsMyPersonalTry
    {
        static void Main()
        {
            var demons = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var patern = @"-?\d+\.?\d*";
            var regex = new Regex(patern);


            var demonsHealth = new SortedDictionary<string, int>();
            var demonsDamage = new SortedDictionary<string, double>();


            foreach (var demon in demons)
            {
                var health = demon.Where(s => !char.IsDigit(s) && s != '+' && s != '-' && s != '*' && s != '/' && s != '.').Sum(s => s);

                demonsHealth.Add(demon,health);

                var matches = regex.Matches(demon);

                var damage = 0.0;

                foreach (Match match in matches)
                {
                     damage += double.Parse(match.Value);

                }

                foreach (var symbols in demon)
                {
                    if (symbols == '*')
                    {
                        damage *= 2;
                    }
                    else if (symbols == '/')
                    {
                        damage /= 2;
                    }
                }

                demonsDamage.Add(demon, damage);
            }

            foreach (var demon in demonsHealth)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value} health, {demonsDamage[demon.Key]:F2} damage");
            }


        }
    }
}
