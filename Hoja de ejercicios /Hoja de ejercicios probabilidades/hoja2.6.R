# Elegir un numero entre el 1 y 30 . Probabilidad de que sea primo o multiplo de 5.
library(matlab)

S = expand.grid(numeros=c(1:30))
Probs = c(rep(1/30, 30))
S = data.frame(S, Probs)

Pprimo = subset(S, as.logical(isprime(numeros)))
PMul5 = subset(S, numeros%%5 == 0)

Prob = function(Conjunto) {
  return(sum(Conjunto$Probs))
}

Interseccion = function(X, Y) {
  T1 = length(X$numeros)
  T2 = length(Y$numeros)
  R = NULL
  for (i in 1:T1)
    for (j in 1:T2)
      if (X$numeros[i] == Y$numeros[j]) 
        R = rbind(R, X[i,])
  return(R)
}

print(Prob(Pprimo) + Prob(PMul5) - Prob(Interseccion(Pprimo, PMul5)))


