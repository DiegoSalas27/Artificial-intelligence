# Si H es que nazca un hombre y M una mujer, tenemos los siguientes casos
# favorables: HHM-HMH-MHH 

# La probabilidad de cada uno de estos eventos es: (1/2) * (1/2) * (1/2) = 1/8

hijos = c("H", "M")
c = permutations(2, 3, hijos, repeats.allowed = T)

conjunto = expand.grid(numeros=c(1:8))
conjunto = data.frame(conjunto, c)

contador = function(Conjunto) {
  T1 = nrow(c)
  cont = 0
  for (i in 1:T1)
    if ((Conjunto$X1[i] == "H" & Conjunto$X2[i] == "H" & Conjunto$X3[i] != "H") ||
        (Conjunto$X2[i] == "H" & Conjunto$X3[i] == "H" & Conjunto$X1[i] != "H") ||
        (Conjunto$X1[i] == "H" & Conjunto$X3[i] == "H" & Conjunto$X2[i] != "H")) {
      cont = cont + 1
    }
  return(cont)
}

print(contador(conjunto)/8)
