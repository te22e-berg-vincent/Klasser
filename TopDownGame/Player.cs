class Player
{ //Kan inte göra if satser

    public Rectangle Hitbox = new(360, 550, 80, 20);
    public Color Colour = Color.BLACK;
    public int Hitpoints = 100;
    public int HitboxMax = 100;
    public int Levle = 1;
    public int Exp = 0;
    public float Speed = 3;

    public void Update()
    {
    if(Raylib.IsKeyDown(KeyboardKey.Left)) Hitbox.x-= Speed;
    if(Raylib.IsKeyDown(KeyboardKey.Right)) Hitbox.x += Speed;

    }
    public void Draw()
    {
        Raylib.DrawRectangleRec(Hitbox,Colour);
    }
}
