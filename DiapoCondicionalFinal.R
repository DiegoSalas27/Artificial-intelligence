#espacio muestral
S = expand.grid(A=c("Largo", "Corto"), B=c("Plana", "Estrella"))
Cant = c(40, 60, 15, 20)
S = data.frame(S, Cant)
S = data.frame(S, Probs = rep(0, 4))
for (i in 1:4)
  S$Probs[i] = S$Cant[i]/sum(S$Cant)

Largo = subset(S, A == "Largo")
Corto = subset(S, A == "Corto")
Plana = subset(S, B == "Plana")
Estrella = subset(S, B == "Estrella")

Prob = function(Conjunto) {
  return(sum(Conjunto$Probs))
}

Interseccion = function(X, Y) {
  T1 = length(X$Cant)
  T2 = length(Y$Cant)
  R = NULL
  for (i in 1:T1)
    for (j in 1:T2)
      if(X$A[i] == Y$A[j] & X$B[i] == Y$B[j])
        R = rbind(R, X[i, ])
  return(R)
}

Condicional = function(A, B) {
  return (Prob(Interseccion(A, B))/Prob(B))
}

Dependencia = function(A, B) {
  if (Condicional(A, B) == Prob(A)) {
    print("Independiente")
  } else {
    print("Dependiente")
  }
}

print(Largo)
print(Corto)
print(Plana)
print(Estrella)

print(Prob(Largo))
print(Interseccion(Corto, Plana))
print(Condicional(Largo, Plana))
print(Dependencia(Corto, Plana))


