using CollisioneurCarré;
using Raylib_cs;
using static Raylib_cs.Raylib;

InitWindow(500, 500, "Hello World");

SetTargetFPS(1);

Drawing main = new Drawing();
main.Init();

while (!WindowShouldClose())
{
    BeginDrawing();

    ClearBackground(Color.WHITE);
    main.Auto();
    main.Render();

    EndDrawing();
}

CloseWindow();