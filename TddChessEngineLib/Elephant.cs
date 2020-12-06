using System;
namespace TddChessEngineLib
{
    public enum letters { A,B,C,D,E,F,G,H }
    public class Elephant
    {
        public string CurrentPosition { get; private set; }
        public Elephant(string newPosition){
            int pos =  Convert.ToInt32(newPosition[1].ToString());
            string let = newPosition[0].ToString();
            if (let!="A"&&let!="B"&&let!="C"&&let!="D"&&let!="E"&&let!="F"&&let!="G"&&let!="H"){
                throw new ArgumentException("Wrong letter!");
            }
            if (pos>8 || pos<1){
                throw new ArgumentException("Wrong number!");
            }
            CurrentPosition = let+pos;
        } 
        public letters GetLetter(string let){
            switch (let){
                case "A":
                    return letters.A;
                case "B":
                    return letters.B;
                case "C":
                    return letters.C;
                case "D":
                    return letters.D;
                case "E":
                    return letters.E;
                case "F":
                    return letters.F;
                case "G":
                    return letters.G;
                case "H":
                    return letters.H;
                default:
                    throw new ArgumentException("Wrong letter!");
            }
        }
        public void Move(string newPosition){
            int pos =  Convert.ToInt32(newPosition[1].ToString());
            letters let = GetLetter(newPosition[0].ToString());
            letters curlet = GetLetter(CurrentPosition[0].ToString());
            //if (int.Parse(curlet)-int.Parse(let){

            //}
        }
    }
}