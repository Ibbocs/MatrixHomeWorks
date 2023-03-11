namespace MentorOOP.Task3
{
    public class Player : Game
    {
        public Player(int _healthPoints, int _attackPower, int _velocity)
        {
            healthPoints = _healthPoints;
            attackPower = _attackPower;
            velocity = _velocity;
        }

        public override bool Movement()
        {
            attackPower -= 5;
            velocity += 6;

            return true;
        }
    }


}
