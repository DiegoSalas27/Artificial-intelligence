import nltk
from nltk.corpus import PlaintextCorpusReader
from nltk.text import Text
ruta = 'C:\\Users\\Laboratorio 12\\PycharmProjects\\untitled'
archivo = 'corpus.txt'
lectordetexto =PlaintextCorpusReader(ruta, archivo, encoding='utf8')
temp = lectordetexto.words()
texto = Text(temp)
print(texto)

#cuantas veces se presente
print(texto.count('inteligencia'))

#cuenta cauntas palabras le anteceden a esta palabra
print(texto.index('inteligencia'))

#muestra donde se repite esta palabra
print(texto.concordance('inteligencia'))

#dispersion muestra en que zona se esta repitiendo esas palabras
print("dispersion")
texto.dispersion_plot(['inteligencia', 'máquina'])

#Frecuencia
print("Frecuencia")
Frecuencia = {'inteligencia':20, 'máquina':11, 'aprendizaje':5, 'malo':1}
print(Frecuencia['inteligencia'])
print(len(Frecuencia))
print(str(Frecuencia))
print(Frecuencia.keys()) #llaves
print(Frecuencia.values()) #valores
print(Frecuencia.items()) #todas la relaciones llave y valor

texto1 =['hola','quetal','hola']
fdist = nltk.FreqDist(texto1)
print(fdist)

print(list(nltk.FreqDist.keys(fdist)))
print(list(nltk.FreqDist.values(fdist)))



