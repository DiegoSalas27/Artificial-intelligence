# Hay 4 corredores. Se pide determinar la probabilidad de cada uno de ganar. Los casos totales
# seran la suma de todas las probabilidades

# a = 2b; c = b/2; b = 2/a; d = 2b
# casos totales: 2b + b/2 + b + 2b = 11b/2
# son eventos mutuamente excluyentes
# casos favorable / casos totales

#P(c) = (b/2) / (11b/2)
c = 1/11
#P(a) = (2b) / (11b/2) -> P(Q) = 1 - P(A)
a = 1 - 4/11
#P(a o c) = P(a) + P(c) - P(a n c)
Paoc = 4/11 + 1/11

S = data.frame(c, a, Paoc)
S
