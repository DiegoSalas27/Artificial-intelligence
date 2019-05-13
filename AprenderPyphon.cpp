# REDONDEO
round(45.6666,2)  # SALIDA  45.67

# Multiplicador y concatenación
3 * 'A' + '5'   # 'AAA5'
4 ** 3 # 4 al cubo

# CAMBIA Y OBTENER DIRECTORIO DE TRABAJO
import os 
os.chdir('E:\Misitio')
os.getcwd()

# CADENA COMO ARRAY
Var = 'UNMSM'
Var[3]  # 'S'
Var[-3] # 'M'  con negativos inicia del final
Var[1:3] # 'NM'

# Tamaño de la cadena
len (Var) 

# LISTAS con letras
Letras = ['a','b','c','d']
print(Letras)
print('dd ,4,'ffff',6) # salidas
Letras.append('e') # agrega al final, la lista puede ser usado como pila
Letras.insert(3,'r') # inserta en la posicion 3
Letras.pop() # eliminar la cima el ulitmo
Letras.pop(2) # eliminar y retorna el valor del indice 2
Letras.remove('y') # elminar el primer valor
Letras.reverse() # modifica a reversa
Letras.sort() # Ordena
Letras.count('d') #Cuenta ds
Letras.clear() # vacia todo los elementos
Letras[1:2] = []  # quitando desde posicion 1 a 2

#LISTA O VECTOR
print("------ LISTA O VECTOR ----- \n")
Vector = [2,3,3,4,8]
print(Vector)

# FOR CON VECTOR
print("------ FOR CON VECTOR ----- \n")
for i in Vector:
    if i % 2 == 0:
        print(i)
    else:
        print("correr")

# FOR CON RANGO
print("------ FOR CON RANGO ----- \n")
for i in range(6):
        print(i)
for num in range(2, 10):
	if num % 2 == 0:
	print("Encontré un número par", num)
	continue
	print("Encontré un número", num)
		
a, b = 0, 1
while b < 10:
	print(b)
	a, b = b, a+b
print(b)

#NUMERACION
print("------ NUMERACION ----- \n")        
a = ['Mary', 'had', 'a', 'little', 'lamb']
for i in range(len(a)):
     print(i, a[i])
     
# LISTAS
print("------ LISTAS ----- \n")
Lista = [1,2,3,4,5]
print(Lista[0])
print(Lista[-1])
print(Lista[:])
Lista.append(6)
print(Lista)
Lista.pop(5)
print(Lista)

Lista=list(range(5)) # crea lista a partir de iterables



#LECTURA DE DATOS
print("------ DESDE TECLASO ----- \n")
#Var3 = int(input())
#Var4 = int(input())
#Resultado = Var3 + Var4
#print(Resultado)





#FUNCIONES
def sumar(a,b):
    return a+b
Suma = sumar(6,8)
print(Suma)

def fib(n): # escribe la serie de Fibonacci hasta n
	"""Escribe la serie de Fibonacci hasta n."""
	a, b = 0, 1
	while a < n:
		print(a, end=' ')
		a, b = b, a+b
		print()
fib(2000)

#TRABAJANDO CON LISTAS CON ARRAY


# Manejando cola, esta con las colecciones
from collections import deque
Cola = deque(['Luz','Julia','Juan'])
Cola.append('Pedro') # agrega a la cola, es decir al final
Cola.appendleft('Justa') # agrega el primero
Cola.pop() # elimina el ultimo
Cola.popleft() # elimina desde izquierda
Lista.rotate() # el ultimo pasa a al primero y el resto recorre
Cola=sorted(Cola) # ordenanado

#Eliminar por indice
Lista = ['Julia', 'Luz', 'Juan', 'Pedro'] 
del Lista[1] #elimina Luz
del Lista # elimina variable

#TUPLAS
Tupla = 45,23,'Hugo',4.77 #(45, 23, 'Hugo', 4.77)
Tupla[1]

#CONJUNTO
Conjunto = {'manzana', 'naranja', 'manzana', 'pera', 'naranja', 'banana'}
'naranja' in Conjunto # verifica si esta en conjunto TRUE OR FALSE
a = set('abracadabra') # equivale a {'a', 'd', 'b', 'r', 'c'}
b = set('alacazam') # {'z', 'a', 'l', 'm', 'c'}
a-b  # {'b', 'd', 'r'}
a | b #{'z', 'a', 'd', 'b', 'r', 'l', 'm', 'c'} a o b todos
a & b # {'a', 'c'} intersection 
a ^ b # {'z', 'd', 'b', 'r', 'l', 'm'} a o b pero no ambos

a = {x for x in 'abracadabra' if x not in 'abc'}
a # a tiene {'r', 'd'}

#Diccionarios clave y valor
Dict = {'sonia':4254,'Pedro':859,'Salas':789}
Dict.keys() # muestra solo claves
Dict['Julia']=536 #Agrega al diccionario
del Dict['Julia'] # elimina la clave julia y su valor
list(Dict.keys()) # pone en lista las claves
sorted(Dict.keys()) # ordena claves
'sonia' in Dict # devuelve true si clave esta en diccionario
'nonia' not in Dict # deuvel verdad si no esta
Dict1={x: x ** 2 for x in (2, 4, 6)} # creando claves y valor
Dict.pop('sonia') #elimina de acuerdo a la clave
Dict.values() # muestra los valores sin clave
Dict.popitem() # elimina el ultimo
Dict['Pedro']=888 # modifica
caballeros = {'gallahad': 'el puro', 'robin': 'el valiente'} # un diccionario
for k, v in caballeros.items():
	print(k, v)
preguntas = ['a','b','c','d']
espuestas=['x'.'y','z','b']
for p, r in zip(preguntas, respuestas):
	print('Cual es tu {0}? {1}.'.format(p, r))

for p, r in zip(preguntas, respuestas): 

#MODULOS
''' módulo de números Fibonacci guardar esto en fibo.py
def fib(n): # escribe la serie Fibonacci hasta n
	a, b = 0, 1
	while b < n:
		print(b, end=' ')
		a, b = b, a+b
	print()
def fib2(n): # devuelve la serie Fibonacci hasta n
	resultado = []
	a, b = 0, 1
	while b < n:
		resultado.append(b)
		a, b = b, a+b
	return resultado
#agregando esto para que sea ejecutado directamente con Python.exe
if __name__ == "__main__":
	import sys
	fib(int(sys.argv[1]))
	print(fib2(int(sys.argv[2])))
	
# en otro archivo
import fibo 
fibo.fib(20)
print(fibo.fib2(20))  ver que devuelve en lista
# ejecuntado con python.exe
c:\...\python.exe c:\...\fibo 50 100
# oserversar que 50 es para fib y 100 fib2 esto preparado en el archivo fibo.py
'''

#importanto y viendo sus métodos
import math
dir(math)  #observar la lista que sus métodos

#FORMATO de salida
x = 10 * 3.25
y = 200 * 200
print('El nivel es {} por tanto debe pagar "{}!"'.format(x, y))
print('El valor de PI es aproximadamente %5.3f.' % math.pi) #viejo formato

#MANEJO DE ARCHIVOS
'''
f = open('archivo.txt', 'r') # lee archivo crear archivo para probar
Contenido1 = f.read() # lee todo
Contenido2 = f.readline() # lee la primera linea
print(Contenido1)
print(Contenido2)



#CLASES
'''
class MiClase:
    """Simple clase de ejemplo"""
    i = 12345
    def funcion1(self): # self  simismo puede ser cualquier variable
        print('hola mundo')
    def funcion2(mi): # usando otro para referirse a si mismo
        return "quetaol"
    def hacer_global(self):
        global var2  # es global del sistema
        var2= 56
    def hacer_local(): #el metodo es automaticamente local, teniendo la idea de invocar dentro de la clase no lleva self, si invocas desde la instancia no procede
        var1 = "algo local"  # es local  solo puede retornar no es accesible desde instancia ni desde la clase
        print(var1)
        var3 = "que es"  # es local
        return var3

    print(hacer_local())  #invoca y ver que no son accesibles como variable

Instancia = MiClase() #instanciando
Instancia.funcion1() # invocando a funcion1
print(Instancia.funcion2()) # invocando a funcion2
print(Instancia.i) # invocando al atributo

Instancia.hacer_global() #invocando al método para tener la variable global
print(var2)  # sale 56 es global de todo el sistema

# MAS CLASES
class Complejo:
    def __init__(self, partereal, parteimaginaria):
        self.r = partereal
        self.i = parteimaginaria
x = Complejo(3.0, -4.5)
print(x.r, x.i)

# OBJETO PERRO
'''
class Perro:
    tipo = 'canino' # variable de clase compartida por todas las instancias
    def __init__(self, nombre):
        self.nombre = nombre # variable de instancia única para la instancia
d = Perro('Fido')
e = Perro('Buddy')

print(d.tipo) # compartido por todos los perros
print(e.tipo) # compartido por todos los perros

print(d.nombre) # único para d
print(e.nombre) # único para e
'''
#OTRO OBJETO
'''
class Perro:
    trucos = [] # uso incorrecto de una variable de clase
    def __init__(self, nombre):
        self.nombre = nombre
    def agregar_truco(self, truco):
        self.trucos.append(truco)

d = Perro('Fido')
e = Perro('Buddy')
d.agregar_truco('girar')
e.agregar_truco('hacerse el muerto')
print(d.trucos) # compartidos por todos los perros inesperadamente
# salida ['girar', 'hacerse el muerto']
'''

# El diseño correcto de esta clase sería usando una variable de instancia
'''
class Perro:
    def __init__(self, nombre):
        self.nombre = nombre
        self.trucos = [] # crea una nueva lista vacía para cada perro
    def agregar_truco(self, truco):
        self.trucos.append(truco)

d = Perro('Fido')
e = Perro('Buddy')
d.agregar_truco('girar')
e.agregar_truco('hacerse el muerto')

print(d.trucos)
# salida ['girar']
print(e.trucos)
# salida  ['hacerse el muerto']
'''

#Los métodos pueden llamar a otros métodos de la instancia usando el argumento self:
'''
class Bolsa:
    def __init__(self):
        self.datos = []
    def agregar(self, x):
        self.datos.append(x)
    def dobleagregar(self, y):
        self.agregar(y)
        self.agregar(y)

Nombre1 = Bolsa()

Nombre1.agregar('Pedro')
print(Nombre1.datos) # ['Pedro']
Nombre1.dobleagregar('Julia')
print(Nombre1.datos) # ['Pedro', 'Julia', 'Julia']
'''

#OBJETO 1
'''
class perro():

  def __init__(elmismo, nombre, size, raza):
      elmismo.nombre=nombre
      elmismo.size=size
      elmismo.raza=raza

  def ladra(elmismo):
     s=""
     for l in elmismo.nombre:
      s+="wof"
     print(s)

chucho=perro("chucho","grande","husky")
chucho.ladra()

cloe=perro("cloe","mini","chihuahua")
cloe.ladra()
'''

#OBJETO 2
'''
class Alumno:
    'Clase para alumnos'
    numalumnos = 0
    sumanotas = 0

    def __init__(mira, nombre, nota):
        mira.nombre = nombre
        mira.nota = nota
        Alumno.numalumnos += 1
        Alumno.sumanotas += nota

    def mostrarNombreNota(mira):
        return(mira.nombre, mira.nota)

    def mostrarNumAlumnos(mira):
        return(Alumno.numalumnos)

    def mostrarSumaNotas(mira):
        return(Alumno.sumanotas)

    def mostrarNotaMedia(mira):
        if Alumno.numalumnos > 0:
            return(Alumno.sumanotas/Alumno.numalumnos)
        else:
            return("Sin alumnos")

alumno1 = Alumno("Maria", 8)
alumno2 = Alumno("Carlos", 6)
print(alumno1.nombre)
print(alumno1.nota)
print(alumno2.nombre)
print(alumno2.nota)
'''

#ITERADORES
'''
for elemento in [1, 2, 3]:
    print(elemento)
for elemento in (1, 2, 3):
    print(elemento)
for clave in {'uno':1, 'dos':2}:
    print(clave)
for caracter in "123":
    print(caracter)
for linea in open("archivo.txt"): #leer archivo
    print(linea, end='') # visualiza linea en linea
'''

# BILIOTECA ESTANDAR
import os  #funciones para interactuar con el sistema operativo:
os.getcwd() # devuelve el directorio de trabajo actual
dir(os) #devuelve una lista de todas las funciones del módulo
import shutil #administración de archivos y directorios
# shutil.copyfile('datos.db', 'archivo.db') #salida 'archivo.db'
# shutil.move('/build/executables', 'dir_instalac') #'dir_instalac'
import sys # procesar argumentos de linea de órdenes, lmacenan en el atributo argv del módulo sys

# MATEMATICAS
import math
Var1 = math.cos(math.pi / 4)
print(Var1)

# ALEATORIO
import random
Var2 = random.choice(['apple', 'pear', 'banana'])
print(Var2)
random.sample(range(100), 10) # elección sin reemplazo 10 elementos
random.random() # un float al azar
random.randrange(6) # un entero al azar tomado de range(6)


#ESTADISTICA
import statistics
data = [2.75, 1.75, 1.25, 0.25, 0.5, 1.25, 3.5]
print(data)
print(statistics.mean(data))
print(statistics.median(data))
print(statistics.variance(data))

#IMPORTANDO módulos
import datetime #importa todo el modelo como objeto-----El módulo datetime ofrece clases para manejar fechas y tiempos
hoy = datetime.date.today() #observe modulo.objeto.metodo
print(hoy) # datetime.date(2017, 8, 28)
# otra forma es traer especificamente objeto que está en el módulo
from datetime import date
hoy1 = date.today()
print(hoy1) # datetime.date(2017, 8, 28)
#calculando edad con aritmetica de fechas
hoy = datetime.date.today()
nacimiento = date(1972, 10, 8)
edad = hoy-nacimiento
print(edad.days) # edad en dias



#OBJETOS
print("------ objeto----- \n")
class Alumno:
    'Clase para alumnos'
    numalumnos = 0
    sumanotas = 0

    def __init__(mira, nombre, nota):
        mira.nombre = nombre
        mira.nota = nota
        Alumno.numalumnos += 1
        Alumno.sumanotas += nota

    def mostrarNombreNota(mira):
        return(mira.nombre, mira.nota)

    def mostrarNumAlumnos(mira):
        return(Alumno.numalumnos)

    def mostrarSumaNotas(mira):
        return(Alumno.sumanotas)

    def mostrarNotaMedia(mira):
        if Alumno.numalumnos > 0:
            return(Alumno.sumanotas/Alumno.numalumnos)
        else:
            return("Sin alumnos")

alumno1 = Alumno("Maria", 8)
alumno2 = Alumno("Carlos", 6)
print(alumno1.nombre)
print(alumno1.nota)

# name y main, name es para referencia si se importa como modulo, y main es para hacer que sea programa principal
def hacer_algo():
    print "algo"
# esta seria ejectnado como programa principal
if __name__ == "__main__":
    print 'Ejecutando como programa principal'
    hacer_algo()

# esto sería ejecutnado como moudlo aqui trabaja el main
import mi_modulo
mi_modulo.hacer_algo()


#PARA INSTALAR 
#estando en director de Python
#python C:\Users\David\AppData\Local\Programs\Python\Python36-32\Scripts\pip install utils

#para procesamiento de imagenes
# 1) instalar cloud reconoction
# 2) instalar libxxx
# 3) instalar chardet
# 4) instalar certifi
# 4) instalar idna

# 5) instalar matplotlib  grafico
# 6) instalar pandas  libreria herramienta de analisis
# 7) instalar sklearn
# 8) instalar scipy
http://python-para-impacientes.blogspot.pe/2015/06/
https://github.com/aimacode/aima-python/blob/master/search.py
http://aima.cs.berkeley.edu/python/search.html

JAVA SIMULATED ANNEALING
http://www.theprojectspot.com/tutorial-post/simulated-annealing-algorithm-for-beginners/6

myvar = 'hello'
myvar.upper()  // convierte a mayuscula


B = [1,8,3,2]
B.sort()  //ordena


