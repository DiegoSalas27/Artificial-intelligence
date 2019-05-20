# Hay 3 caballos. Se pide determinar la probabilidad de cada uno de ganar. Los casos totales
# seran la suma de todas las probabilidades

# a = b/2; c = 2b; b = 2a;
# casos totales: b/2 + 2b + b = 7b/2
# son eventos mutuamente excluyentes
# casos favorable / casos totales

#P(a) = (b/2) / (7b/2)
a = 1/7
#P(b) = (b) / (7b/2)
b = 2/7
#P(c) = (2b) / (7b/2)
c = 4/7

S = data.frame(a, b, c)
S
