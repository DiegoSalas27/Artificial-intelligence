# casos totales = 50. son 6 casos favorables. Solucion: casos favorables / casos totales
# 6 / 50

S = expand.grid(numeros=c(1:50))
M = subset(S, numeros%%3 == 0 & numeros < 20)

P = length(M$numeros)/ length(S$numeros)
P


