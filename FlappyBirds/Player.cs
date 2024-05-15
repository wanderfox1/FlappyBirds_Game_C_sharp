using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBirds
{
    class Player
    {
        public float x;
        public float y;

        public int size;
        public int score;

        public float gravityValue;

        public Image birdImg;

        public bool isAlive;

        // конструктор, в к-м всё объявляется
        public Player(int x, int y)
        {
            birdImg = new Bitmap("C:\\Users\\79265\\Desktop\\flappy.png");
            this.x = x;
            this.y = y;

            size = 50;
            gravityValue = 0.1f;
            isAlive = true;
            score = 0;
        }
    }
}
