using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexGenerator
{
    class Individual
    {
        public RegexTree regex_tree;
        public double prob;
        public double h, l, f;
        public Individual(RegexTree regex_tree)
        {
            this.regex_tree = regex_tree;
        }
    }
    class Genetic
    {
        public int epochs;
        public int population_size;
        public int elitism_count;
        public int random_count;
        public int maxdepth;
        public Dataset train;
        public string input;
        Random rnd = new Random();
        //public Dataset test;
        public Genetic(int epochs, int population_size, int elitism_count,int random_count, int maxdepth, Dataset train, string input) // data
        {
            this.epochs = epochs;
            this.population_size = population_size;
            this.elitism_count = elitism_count;
            this.random_count = random_count;
            this.maxdepth = maxdepth;
            this.train = train;
            this.input = input;
            //this.test = test;
        }
        public static bool IsValidRegex(string pattern)
        {
            if (string.IsNullOrWhiteSpace(pattern)) return false;

            try
            {
                Regex.Match("", pattern);
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }

            return true;
        }
        public RegexTree GenerateIndividual()
        {
            var new_node = new RegexTree(RegexTree.Create.byRandom, maxdepth);
            string rgx = new_node.GenerateRegexString();
            while(!IsValidRegex(rgx))
            {
                new_node = new RegexTree(RegexTree.Create.byRandom, maxdepth);
                rgx = new_node.GenerateRegexString();
            }
            return new_node;
        }
        public List<Individual> GenerateStartPopulation(int size)
        {
            List<Individual> new_list = new List<Individual>();
            for (int i =0; i<size;i++)
            {
                new_list.Add(new Individual(GenerateIndividual()));
            }
            return new_list;
        }
        class fit
        {
            public double h { get; set; }
            public double l { get; set; }
            public double f { get; set; }
            public fit(double h, double l, double f)
            {
                this.h = h;
                this.l = l;
                this.f = f;
            }
        }

        fit Fitness(RegexTree ind)
        {
            int h = 0;
            var rgx = ind.GenerateRegexString(ref h);
            int found_all = 0;
            double found_not_full_all = 0;
            double levsum_all = 0;
            int tp=0; int tn=0;
            int fp=0; int fn=0;

            using(StreamReader sr = new StreamReader(input))
                for (int i = 0; i < train.data.Length; i++)
                {
                    string cur_str = sr.ReadLine();
                    List<int> starts = new List<int>();
                    List<int> ends = new List<int>();
                    List<string> vals = new List<string>();

                    try
                    {
                        Match match = Regex.Match(cur_str, rgx);
                        while (match.Success)
                        {
                            starts.Add(match.Index);
                            ends.Add(match.Index + match.Length - 1);
                            vals.Add(match.Value);
                            match = match.NextMatch();
                        }
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Exeption");
                    }
                    
                    int found_full = 0;
                    int found_not_full = 0;
                    double levsum = 0;
                    double[] train_max_ch_found = new double[train.data[i].Count];
                    for (int m = 0; m < train.data[i].Count; m++)
                    {
                        train_max_ch_found[m] = 0;
                    }

                    for (int k =0;k<starts.Count;k++)
                    {
                        for(int m =0;m<train.data[i].Count;m++)
                        {

                            if (starts[k] == train.data[i][m].start && ends[k] == train.data[i][m].end)
                            { 
                                found_full++;
                            }
                            if (starts[k] >= train.data[i][m].start && ends[k] <= train.data[i][m].end)
                            { 
                                found_not_full++;
                                train_max_ch_found[m] = Math.Max(
                                    Convert.ToDouble(ends[k] - starts[k] + 1) / train.data[i][m].str.Length, 
                                    train_max_ch_found[m]
                                    );
                                levsum += StringDistance.LevenshteinDistance(vals[k], train.data[i][m].str)/ train.data[i][m].str.Length;
                            }
                        }
                    }
                    for (int m = 0; m < train.data[i].Count; m++)
                    {
                        found_not_full_all += train_max_ch_found[m];
                    }

                    tp += found_full;
                    found_all += found_not_full;
                    fp += starts.Count - found_full;
                    if (train.data[i].Count == 0 && starts.Count == 0)
                        tn++;
                    if (starts.Count == 0 && train.data[i].Count != 0)
                        fn++;
                    if (starts.Count != 0 && train.data[i].Count == 0)
                        fp += starts.Count;
                    levsum_all += levsum;
                }

            double result_lev = (found_all != 0) ? levsum_all / found_all : 0;
            double precision = (tp + fp != 0) ? Convert.ToDouble(tp) / (tp + fp) : 0;
            double recall = ((tp + fn) != 0 && tp != 0) ? Convert.ToDouble(tp) / (tp + fn) : 1;
            double result_fscore = 2 * (precision * recall) / (precision + recall);





            result_fscore = tp/86; // accuracy
            result_lev = found_not_full_all/86;




            var ft = new fit(Convert.ToDouble(maxdepth - h)/maxdepth, result_lev, result_fscore);
            return ft;
        }
        double Probability(double h, double l, double f)
        {
            return h*0 + l*0 + f + 0.05;
        }
        double CountProbs(List<Individual> population)
        {
            double res = 0;
            for (int i = 0; i < population.Count; i++)
            {
                fit f = Fitness(population[i].regex_tree);
                population[i].prob = Probability(f.h,f.l,f.f);
                res += population[i].prob;
                population[i].f = f.f;
                population[i].h = f.h;
                population[i].l = f.l;
            }
            return res;
        }
        public T GetRandomItem<T>(IEnumerable<T> itemsEnumerable, Func<T, double> weightKey)
        {
            var items = itemsEnumerable.ToList();

            var totalWeight = items.Sum(x => weightKey(x));
            var randomWeightedIndex = rnd.NextDouble()* totalWeight;
            var itemWeightedIndex = 0.0;
            foreach (var item in items)
            {
                itemWeightedIndex += weightKey(item);
                if (randomWeightedIndex < itemWeightedIndex)
                    return item;
            }
            throw new ArgumentException("Collection count and weights must be greater than 0");
        }
        public static T CloneJson<T>(T source)
        {
            // Don't serialize a null object, simply return the default for that object
            if (ReferenceEquals(source, null)) return default;

            // initialize inner objects individually
            // for example in default constructor some list property initialized with some values,
            // but in 'source' these items are cleaned -
            // without ObjectCreationHandling.Replace default constructor values will be added to result
            var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };

            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source), deserializeSettings);
        }
        static List<RegexNode> ListNodes(RegexNode node)
        {
            List<RegexNode> lst = new List<RegexNode>();
            if (node.isLeaf) return lst;
            lst.Add(node);
            foreach (var n in node.list)
            {
                var new_lst = ListNodes(n);
                if(new_lst.Count>0) lst.AddRange(new_lst);
            }
            return lst;
        }
        Tuple<RegexTree, RegexTree> Crossover(RegexTree ind1, RegexTree ind2)
        {
            var lst1 = ListNodes(ind1.Tree);
            var lst2 = ListNodes(ind2.Tree);

            var rnd1 = rnd.Next(lst1.Count);
            var rnd2 = rnd.Next(lst2.Count);

            var t = lst1[rnd1].list;
            lst1[rnd1].list = lst2[rnd2].list;
            lst2[rnd2].list = t;

            var trgx = lst1[rnd1].template;
            lst1[rnd1].template = lst2[rnd2].template;
            lst2[rnd2].template = trgx;

            int h1 = 0, h2 = 0;
            var rgx1=ind1.GenerateRegexString(ref h1);
            var rgx2=ind2.GenerateRegexString(ref h2);
            while(!IsValidRegex(rgx1)||!IsValidRegex(rgx2))
            {
                t = lst1[rnd1].list;
                lst1[rnd1].list = lst2[rnd2].list;
                lst2[rnd2].list = t;

                trgx = lst1[rnd1].template;
                lst1[rnd1].template = lst2[rnd2].template;
                lst2[rnd2].template = trgx;

                rnd1 = rnd.Next(lst1.Count);
                rnd2 = rnd.Next(lst2.Count);

                t = lst1[rnd1].list;
                lst1[rnd1].list = lst2[rnd2].list;
                lst2[rnd2].list = t;
                trgx = lst1[rnd1].template;
                lst1[rnd1].template = lst2[rnd2].template;
                lst2[rnd2].template = trgx;

                rgx1 = ind1.GenerateRegexString(ref h1);
                rgx2 = ind2.GenerateRegexString(ref h2);
            }
            return new Tuple<RegexTree, RegexTree>(ind1, ind2);
        }
        List<RegexNode> ListLeafs(RegexNode node)
        {
            List<RegexNode> lst = new List<RegexNode>();
            if (node.isLeaf) 
            {
                lst.Add(node);
                return lst;
            }
            foreach (var n in node.list)
            {
                var new_lst = ListLeafs(n);
                if (new_lst.Count > 0) lst.AddRange(new_lst);
            }
            return lst;
        }
        void Mutate(Individual ind)
        {
            var lst = ListLeafs(ind.regex_tree.Tree);
            int rand = rnd.Next(lst.Count);
            var old = lst[rand].template;

            lst[rand].template = LeafTemplates.getRandomLeaf();
            var rgx = ind.regex_tree.GenerateRegexString();
            while (!IsValidRegex(rgx))
            {
                lst[rand].template = LeafTemplates.getRandomLeaf();
                rgx = ind.regex_tree.GenerateRegexString();
            }
        }
        public void Eval(string output)
        {
            var sw = new StreamWriter(output);
            var startTime = DateTime.Now;
            sw.WriteLine($"Starting {epochs} epochs\n");
            Console.WriteLine($"Starting {epochs} epochs\n");
            var population = GenerateStartPopulation(population_size);
            double sum = CountProbs(population);
            population.Sort((a, b) => 
            { 
                if (a.f==b.f)
                {
                        return b.l.CompareTo(a.l);
                }
                else
                    return b.prob.CompareTo(a.prob);
            });

            for (int epoch = 0; epoch < epochs; epoch++)
            {
                List<Individual> new_population = new List<Individual>();
                double probs_sum = 0;

                int elit = 0;
                foreach(var i in population)
                {
                    if (elit > elitism_count) break;
                    if (elit % 10 == 0) Console.WriteLine(elit);
                    new_population.Add(i);
                    probs_sum += i.prob;
                    elit++;
                }

                while (new_population.Count<population_size-random_count)
                {
                    if (new_population.Count % 100 == 1) Console.WriteLine(new_population.Count);
                    var fst = GetRandomItem(population, x => x.prob);
                    while(fst.regex_tree.Tree.isLeaf)
                        fst = GetRandomItem(population, x => x.prob);
                    var scnd = GetRandomItem(population, x => x.prob);
                    while (scnd.regex_tree.Tree.isLeaf)
                        scnd = GetRandomItem(population, x => x.prob);

                    var temp1 = fst.regex_tree.GenerateRegexString();
                    var temp2 = scnd.regex_tree.GenerateRegexString();

                    var pair = Crossover(CloneJson(fst.regex_tree), CloneJson(scnd.regex_tree));

                    RegexTree Rind1 = pair.Item1, Rind2 = pair.Item2;
                    Individual ind1 = new Individual(Rind1);
                    Individual ind2 = new Individual(Rind2);

                    int do_mutation = rnd.Next(2);
                    if (do_mutation % 2 == 0)
                        Mutate(ind1);
                    else
                        Mutate(ind2);
                    var fit1 = Fitness(ind1.regex_tree);
                    var fit2 = Fitness(ind2.regex_tree);
                    ind1.prob = Probability(fit1.h, fit1.l, fit1.f);
                    ind1.h = fit1.h;
                    ind1.l = fit1.l;
                    ind1.f = fit1.f;
                    ind2.prob = Probability(fit2.h, fit2.l, fit2.f);
                    ind2.h = fit2.h;
                    ind2.l = fit2.l;
                    ind2.f = fit2.f;
                    if (ind1.prob > ind2.prob)
                    {
                        new_population.Add(ind1);
                        probs_sum += ind1.prob;
                        if (new_population.Count >= population_size - random_count) break;
                        new_population.Add(ind2);
                        probs_sum += ind2.prob;
                    }
                    else
                    {
                        new_population.Add(ind2);
                        probs_sum += ind2.prob;
                        if (new_population.Count >= population_size - random_count) break;
                        new_population.Add(ind1);
                        probs_sum += ind1.prob;
                    }
                }
                while (new_population.Count< population_size)
                {
                    if (new_population.Count % 100 == 0) Console.WriteLine(new_population.Count);
                    var new_ind = new Individual(GenerateIndividual());
                    var new_fit = Fitness(new_ind.regex_tree);
                    new_ind.prob = Probability(new_fit.h, new_fit.l, new_fit.f);
                    new_ind.h = new_fit.h;
                    new_ind.l = new_fit.l;
                    new_ind.f = new_fit.f;
                    new_population.Add(new_ind);
                }

                population = new_population;
                sum = probs_sum; // no use
                population.Sort((a, b) => 
                {
                    if (a.f == b.f)
                    {
                        return b.l.CompareTo(a.l);
                    }
                    return b.prob.CompareTo(a.prob);
                });
                var top_prob = population[0].prob;
                var top_h = population[0].h;
                var top_levin = population[0].l;
                var top_fscore = population[0].f;
                var top_rgx = population[0].regex_tree.GenerateRegexString();
                sw.WriteLine($"{epoch} {top_prob} {top_h} {top_levin} {top_fscore} {top_rgx}");
                Console.WriteLine($"{epoch} {top_prob} {top_h} {top_levin} {top_fscore} {top_rgx}");
            }
            var endTime = DateTime.Now;
            var elapsed = endTime - startTime;
            Console.WriteLine($"\nElapsed: { elapsed.TotalSeconds}");
            sw.WriteLine($"\nElapsed: {elapsed.TotalSeconds}");
            sw.Close();

        }
    }
    class Program
    {
        private static void Main(string[] args)
        {
            var train = new Dataset("../../../data.json");
            Genetic gen_algo = new Genetic(
                epochs: 100,
                population_size: 500,
                elitism_count: 50,
                random_count: 400,
                maxdepth: 6,
                train: train,
                input: "../../../../html-example.txt");
            gen_algo.Eval("../../../../output.txt");
        }
    }
}