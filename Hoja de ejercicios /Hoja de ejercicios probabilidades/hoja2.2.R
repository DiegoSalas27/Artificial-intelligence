# Hay 21 tarjetas. Las tarjetas cuya suma de digitos es 3 o 4  son: 12, 13, 21, 22, 30. Cinco
# Casos favorables en total. Probabilidad pedida = casos favorables/ casos totales 
# P = 5/21 

t = expand.grid(Tarjetas = c(10:30))
probs = c(rep(1/21, 21))
t = data.frame(t, probs)

A = c()

calcularTarjetas = function(arreglo) {
  T1 = length(arreglo$Tarjetas)
  
  for (i in 1:T1) {
    a = arreglo$Tarjetas[i]%%10
    b = arreglo$Tarjetas[i]%/%10
    if(a + b == 3 || a + b == 4) {
      A <- c(A, arreglo$Tarjetas[i])
    }
  }
  return(A)
}

n = length(calcularTarjetas(t))
P = n/length(t$Tarjetas)
print(P)
