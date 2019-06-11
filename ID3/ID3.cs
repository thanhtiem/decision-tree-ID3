using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3
{
    class DecisionTreeID3
    {
        List<List<string>> Examples;
        List<Attribute> Attributes;
        public List<string> RuleID3 = new List<string>();
        TreeNode _tree;
        int _depth;
        string _solution;
        public int ruleCount;
        string Rule;

        internal TreeNode Tree
        {
            get { return _tree; }
            set { _tree = value; }
        }

        public int Depth
        {
            get { return _depth; }
            set { _depth = value; }
        }

        public string Solution
        {
            get { return _solution; }
            set { _solution = value; }
        }

        public DecisionTreeID3(List<List<string>> Examples, List<Attribute> Attributes)
        {
            this.Examples = Examples;
            this.Attributes = Attributes;
            this.Tree = null;
            Depth = 0;
        }

        // tính entroypy

        private double GetEntropy(int Positives, int Negatives)
        {
            if (Positives == 0)
                return 0;
            if (Negatives == 0)
                return 0;
            double Entropy;
            int total = Negatives + Positives;
            double RatePositves = (double)Positives / total;
            double RateNegatives = (double)Negatives / total;
            Entropy = -RatePositves * Math.Log(RatePositves, 2) - RateNegatives * Math.Log(RateNegatives, 2);
            return Entropy;
        }

        // tính Gain(bestat,A);

        private double Gain(List<List<string>> Examples, Attribute A, string bestat)
        {
            double result;
            int CountPositives = 0;
            int[] CountPositivesA = new int[A.Value.Count];
            int[] CountNegativeA = new int[A.Value.Count];
            int Col = Attributes.IndexOf(A);
            for (int i = 0; i < A.Value.Count; i++)
            {
                CountPositivesA[i] = 0;
                CountNegativeA[i] = 0;
            }
            for (int i = 0; i < Examples.Count; i++)
            {
                int j = A.Value.IndexOf(Examples[i][Col].ToString());
                if (Examples[i][Examples[0].Count - 1] == "1")
                {
                    CountPositives++;
                    CountPositivesA[j]++;
                }
                else
                {
                    CountNegativeA[j]++;
                }
            }
            result = GetEntropy(CountPositives, Examples.Count - CountPositives);
            for (int i = 0; i < A.Value.Count; i++)
            {
                double RateValue = (double)(CountPositivesA[i] + CountNegativeA[i]) / Examples.Count;
                result = result - RateValue * GetEntropy(CountPositivesA[i], CountNegativeA[i]);
            }

            Solution = Solution + "\n * Gain(" + bestat + "," + A.Name + ") = " + result.ToString();
            return result;
        }

        // giải thuật ID3

        private TreeNode ID3(List<List<string>> Examples, List<Attribute> Attribute, string bestat)
        {
            Solution = Solution + "---------------------------------    Xét " + bestat + "     -------------------------------";
            if (CheckAllPositive(Examples))
            {
                Solution += "\n Tất cả các mẫu đều khẳng định => Trả về nút gốc với nhãn 1";
                return new TreeNode(new Attribute("1"));
            }
            if (CheckAllNegative(Examples))
            {
                Solution += "\n Tất cả các mẫu đều phủ định => Trả về nút gốc với nhãn 0";
                return new TreeNode(new Attribute("0"));
            }
            if (Attribute.Count == 0)
            {
                Solution += "\n Các thuộc tính rỗng => Trả về nút gốc có giá trị phổ biến nhất ";
                return new TreeNode(new Attribute(GetMostCommonValue(Examples)));
            }
            Attribute BestAttribute = GetBestAttribute(Examples, Attribute, bestat);
            int LocationBA = Attributes.IndexOf(BestAttribute);
            TreeNode Root = new TreeNode(BestAttribute);
            for (int i = 0; i < BestAttribute.Value.Count; i++)
            {
                List<List<string>> Examplesvi = new List<List<string>>();
                for (int j = 0; j < Examples.Count; j++)
                {
                    if (Examples[j][LocationBA].ToString() == BestAttribute.Value[i].ToString())
                        Examplesvi.Add(Examples[j]);
                }
                if (Examplesvi.Count == 0)
                {
                    Solution += "\n Các thuộc tính rỗng => Trả về nút gốc có giá trị phổ biến nhất ";
                    return new TreeNode(new Attribute(GetMostCommonValue(Examplesvi)));
                }
                else
                {
                    Solution += "\n";
                    Attribute.Remove(BestAttribute);
                    Root.AddNode(ID3(Examplesvi, Attribute, BestAttribute.Value[i]));
                }
            }
            return Root;
        }

        // lấy thuộc tính có Gain cao nhất

        private Attribute GetBestAttribute(List<List<string>> Examples, List<Attribute> Attributes, string bestat)
        {
            double MaxGain = Gain(Examples, Attributes[0], bestat);
            int Max = 0;
            for (int i = 1; i < Attributes.Count; i++)
            {
                double GainCurrent = Gain(Examples, Attributes[i], bestat);
                if (MaxGain < GainCurrent)
                {
                    MaxGain = GainCurrent;
                    Max = i;
                }
            }
            Solution = Solution + "\n\t=> Ta chọn Gain lớn nhất là : " + Attributes[Max].Name;
            return Attributes[Max];
        }

        // lấy giá trị phổ biến nhất của tập đích

        private string GetMostCommonValue(List<List<string>> Examples)
        {
            int CountPositive = 0;
            for (int i = 0; i < Examples.Count; i++)
            {
                if (Examples[i][Examples[0].Count - 1] == "1")
                    CountPositive++;
            }
            int CountNegative = Examples.Count - CountPositive;
            string Label;
            if (CountPositive > CountNegative)
                Label = "1";
            else
                Label = "0";
            Solution = Solution + " là " + Label;
            return Label;
        }

        // kiểm tra xem tất cả tập có phải là positive không

        private bool CheckAllPositive(List<List<string>> Examples)
        {
            for (int i = 0; i < Examples.Count; i++)
            {
                if (Examples[i][Examples[0].Count - 1].ToString() == "0")
                    return false;
            }
            return true;
        }

        // kiểm tra xem tất cả tập có phải là Negative không

        private bool CheckAllNegative(List<List<string>> Examples)
        {
            for (int i = 0; i < Examples.Count; i++)
            {
                if (Examples[i][Examples[0].Count - 1] == "1")
                    return false;
            }
            return true;
        }

        // xây dựng cây

        public void GetTree()
        {
            Solution = "";
            List<Attribute> at = new List<Attribute>();
            for (int i = 0; i < Attributes.Count; i++)
            {
                at.Add(Attributes[i]);
            }
            Tree = ID3(Examples, at, "S");
            Depth = GetDepth(Tree);
        }

        // Tìm luật
        public void SearchRule(TreeNode Rule)
        {
            if (Rule.Attributes.Value.Count == 0)
            { }
            else
            {
                string temp1 = "";
                _solution += Rule.Attributes.Name + " = ";
                temp1 += _solution + " ";
            for (int i = 0; i < Rule.Attributes.Value.Count; i++) 
            {
                    string temp2 = "";
                    temp2 = temp1 + Rule.Attributes.Value[i] + ", ";
                    if (Rule.Childs[i].Attributes.Value.Count == 0)
                    {
                        ruleCount++;
                        _solution = temp2 + "} THEN { "+Rule.Childs[i].Attributes.Label+"} ";
                         RuleID3.Add(_solution);
                    }
                    else
                    {
                        if (Rule.Attributes.Value.Count == 0)
                        {
                            SearchRule(Rule.Childs[i]);
                        }
                        else
                        {
                            _solution = temp2;
                            SearchRule(Rule.Childs[i]);
                        }
                    }
                }
            }
        }
        public void GetRule(TreeNode tree)
        {
            _solution = "";
            Rule += " RÚT RA LUẬT TỪ CÂY QUYẾT ĐỊNH ID3 \n\n";
            SearchRule(tree);
            for (int i = 0; i < ruleCount; i++)
                Rule += " Rule [" + i + "]: IF {" + RuleID3[i] + "\n";
            Rule += "\n Tổng Số Luật: " + ruleCount;
            ruleCount = 0;
        }
        //Tối Ưu Cây Quyết Định.
        public bool CheckAllLabelNegative(TreeNode tree)
        {
            int test = 0;
            string temp;
            temp = "No";
            for (int i = 0; i < tree.Attributes.Value.Count; i++)
            {
                if (tree.Childs[i].Attributes.Label == temp)
                    test++;
            }
            if ((test > 1) && (test == tree.Attributes.Value.Count))
                return true;
            else
                return false;
        }
        // lấy độ sâu của cây

        private int GetDepth(TreeNode tree)
        {
            int depth;
            if (tree.Childs.Length == 0)
                return 1;
            else
            {
                depth = GetDepth(tree.Childs[0]);
                for (int i = 1; i < tree.Childs.Length; i++)
                {
                    int depthchild = GetDepth(tree.Childs[i]);
                    if (depth < depthchild)
                        depth = depthchild;
                }
                depth++;
            }
            return depth;
        }

    }
}
