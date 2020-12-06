using System;
namespace TddChessEngineLib
{
    class Elephant
    {
        public string CurrentPosition { get; private set; }
        
        public Elephant(string newPosition){
            int pos =  Convert.ToInt32(newPosition[1].ToString());
            char let = newPosition[0];
            if (let!='A'&&let!='B'&&let!='C'&&let!='D'&&let!='E'&&let!='F'&&let!='G'&&let!='H'){
                throw new ArgumentException("Wrong letter!");
            }
            if (pos>8 || pos<0){
                throw new ArgumentException("Wrong number!");
            }
        } 

        public void Move(string newPosition){
            
        }
    }
}