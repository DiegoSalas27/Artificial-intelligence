# El espacio muestral de este experimento está formado por los cien sucesos elementales: 
# 00, 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, ..., 98, 99. Para cada sucesos del enunciado 
# calculamos sus casos favorables, aplicamos la regla de Laplace y obtenemos:

c = permutations(10, 2, 0:10, repeats.allowed = T)
c

telefono = expand.grid(numeros=c(0:9))
Probs = c(rep(1/100, 100))
telefono = data.frame(telefono, c, Probs)

sub = subset(telefono, (X1 == X2))
sub2 = subset(telefono, X1 + X2 == 11)

#Probabilidad que las ultimas cifras sean iguales:

print(sum(sub$Probs))

#Probabilidad que las dos ultimas cifras sean 11:

print(sum(sub2$Probs))
