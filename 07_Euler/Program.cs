using static ProjectEuler;

List<Action> opgaver = new List<Action>
{
 ID1, ID2, ID3, ID4, ID5, ID6, ID7, ID8, ID9, ID10, ID11, ID12, ID13, ID14, ID15, ID16, ID17, ID18, ID20, ID21, ID25, ID29
};
int opgN = Int32.Parse(Console.ReadLine());
opgaver[opgN - 1]();