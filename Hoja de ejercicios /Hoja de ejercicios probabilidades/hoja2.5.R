# Lanzar dado y calcular probabilidad  de que el numero sea par o menor a 5

D = expand.grid(lados=c(1:6))
Probs = c(rep(1/6, 6))
D = data.frame(D, Probs)

SubPar = subset(D, lados%%2 == 0)
SubM5 = subset(D, lados < 5)

Prob = function(Conjunto) {
  return (sum(Conjunto$Probs))
}

interseccion = function(X, Y) {
  T1 = length(X$lados)
  T2 = length(Y$lados)
  R = NULL
  for (i in 1:T1)
    for (j in 1:T2)
      if(X$lados[i] == Y$lados[j])
        R = rbind(R, X[i, ])
  return(R)
}

#P(SubPar) = 3/6; P(SubM5) = 4/6 -> P(Subpar) + P(SubM5) - P(SubPar n SubM5)

print(Prob(SubPar) + Prob(SubM5) - Prob(interseccion(SubPar, SubM5)))
