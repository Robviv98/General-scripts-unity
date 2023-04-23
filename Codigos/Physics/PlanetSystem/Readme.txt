English/Español

Google translate has been used to leave the text in English

For this planetary system to work on a small scale, you must have an empty Gameobject which will contain the bodies that will act as
the sun and the planets, the gamobject in my case called PlanetarySystem must have the script DatosGPlanetas, which for the moment only contains the
value of the gravitational constant represented by K.

Each planet and the sun must have the planetary system script, the sun must have the name of Sun, the planets can have the name that it deems appropriate
this one has to adjust a boost to generate official movement (this boost does not apply to an object called "Sun"), and its weight, if the system is stable
It should work correctly, I recommend starting with just one planet and sun and testing the parameters until it works well, then adding planets
until you have the ones you deem fit, the code works with newton's laws, so all the planets are affecting all the other planets
with your gravity, so you may want to wait a while to see if the system is indeed stable.



Español

Para que funcione este sistema planetario a pequeña escala se debe tener un Gameobject vacio el cual contendra los cuerpos que actuaran como
el sol y los planetas, el gamobject en mi caso llamado SistemaPlanetario debetener el script DatosGPlanetas, el cual por el momento solo contiene el
valor de la constante gravitatoria representado por K.

Cada planeta y el sol deben tener el script sistema planetario, el sol debe tener el nombre de Sun, los planetas pueden tener el nombre que estime conveniente
este tiene para ajustar un impulso para generar un movimiento oficial (este impulso no se aplica a un objeto llamado "Sun"), y su peso, si el sistema es estable
deberia funcionar correctamente, recomiendo partir con solo un planeta y sol y ir probando los parametros hasta que funcione bien, despues ir agregando planetas
hasta que tenga los que estime conveniente, el codigo funciona con las leyes de newton, por lo que todos los planetas estan afectando a todos los demas planetas
con su gravedad, por lo que talvez quiera esperar un tiempo para ver si el sistema es efectivamente estable.