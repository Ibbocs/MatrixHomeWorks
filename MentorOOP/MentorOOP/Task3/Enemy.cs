namespace MentorOOP.Task3
{
    public class Enemy : Game
    {
        public Enemy(int _healthPoints, int _attackPower, int _velocity)
        {
            healthPoints = _healthPoints;
            attackPower = _attackPower;
            velocity = _velocity;
        }

        public Enemy()
        {
            healthPoints = 100;
            attackPower = 20;
            velocity = 10;
        }

        public override bool Movement()
        {
            attackPower += 10;
            velocity -= 4;

            return true;
        }
    }


}
