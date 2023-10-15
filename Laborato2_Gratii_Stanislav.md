1.

Se observa ca „MatrixMode.Projection” este utilizată pentru a defini cum sunt reprezentate obiectele în spațiul 2D al ferestrei, în timp ce  "MatrixMode.Modelview"  sunt folosite pentru a aplica transformări asupra obiectelor în spațiul 3D, pentru a le plasa și orienta în scenă. Astfel, „MatrixMode.Projection” controlează cum sunt proiectate obiectele pe ecran, în timp ce "MatrixMode.Modelview" afectează modul în care obiectele sunt reprezentate în spațiul 3D.
3.
⚫Ce este un viewport?
Un viewport este regiunea specifică în care va fi desenat sau afișat obiectul grafic sau conținutul grafic într-o aplicație.  

⚫Ce reprezintă conceptul de frames per seconds din punctul de
vedere al bibliotecii OpenGL?
frames per second sau FPS este viteza de randare a scenei grafice pe ecranul utilizatorului

⚫Când este rulată metoda OnUpdateFrame()?
OnUpdateFrame() este rulată in fiecare cadru (frame) al aplicatiei.

⚫Ce este modul imediat de randare?

⚫Care este ultima versiune de OpenGL care acceptă modul imediat?
OpenGL 3.0. 

⚫Când este rulată metoda OnRenderFrame()?  
La fel ca si OnUpdateFrame() este rulată in fiecare cadru (frame) al aplicatiei,dar după ce  a fost efectuata OnUpdateFrame()

⚫De ce este nevoie ca metoda OnResize() să fie executată cel puțin
o dată?
Trebuie să fie executată cel puțin o dată pentru a iniția afișarea corectă a scenei grafice și pentru a seta dimensiunea și poziția corectă a viewport-ului grafic în fereastra aplicației.

⚫Ce reprezintă parametrii metodei CreatePerspectiveFieldOfView() și care este domeniul de valori
pentru aceștia?

Primul parametru MathHelper.PiOver4 este FOV sau campul de vedere si este exprimat in radiani  
și domeniul de valori intre (0, π).
Parametrul aspectRatio reprezintă raportul dintre lățimea și înălțimea ferestrei sau ecranului. 

zNear și zFar: Acești parametri reprezintă distanța minimă (zNear) și distanța maximă (zFar) la care obiectele 3D vor fi vizibile.zNear su Zfar sunt numere pozitive cu conditia ca zNear < zFar;



 


