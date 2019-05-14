#!/usr/bin/env python
# coding: utf-8

# In[44]:


import itertools as it
import math as mt


# In[156]:


def f(n):
    return mt.factorial(n)

def sod(num):
    suma = 0
    while num > 0:
        d = num%10
        num = num//10
        suma += d
    return suma
def eq(a,b):
    return abs(a-b) < 0.000001


# In[127]:


#Ejemplo
a = list("MEMMER")
perm = list(it.permutations(a))
len(set(perm)) #Set SIN REPETICION


# HOJA 1

# In[139]:


#1
a = [x  for x in range(10)]
perm = list(it.permutations(a,3))
len(perm)


# In[69]:


#2
a = [x  for x in range(8)]
perm = list(it.permutations(a))
len(set(perm))


# In[71]:


#3
a = ['r']*3+['g']*4+['b']*2
perm = list(it.permutations(a))
len(set(perm))


# In[170]:


#4
a = ['1']*3+['2']+['3']*4
perm = list(it.permutations(a))
len(set(perm))


# In[81]:


#5
a = [x  for x in range(5)]
perm = list(it.combinations(a,3))
len(set(perm))


# In[79]:


#6
a = [x  for x in range(30)]
perm = list(it.combinations(a,5))
len(set(perm))


# In[89]:


#7
a = [x  for x in range(6)]
perm = list(it.combinations_with_replacement(a,4))
len(set(perm))


# In[90]:


#7
a = [x  for x in range(5)]
perm = list(it.combinations_with_replacement(a,3))
len(set(perm))


# HOJA 2

# In[157]:


#1
v,a,n=3,2,4
t=v+n+a
pv = v/t
pn = n/t
pt = pv+pn
pt


# In[158]:


#2
a = [x for x in range(10,31)]
p3 = sum([sod(x) % 3 == 0 for x in a]) / len(a)
p4 = sum([sod(x) % 4 == 0 for x in a]) / len(a)
pt = p3+p4
pt


# In[159]:


#3
pb=1
pa = 2*pb
pc = pb/2
pd = pa
t = pa+pb+pc+pd
pa = pa/t
pb = pb/t
pc = pc/t
pd = pd/t


# In[160]:


#3I
pc == 2/11


# In[161]:


#3II
1 - pa == 7/11


# In[164]:


#3III
eq(pa+pc,5/11)


# In[167]:


#4
a = [x for x in range(1,51)]
p3 = sum([x % 3 == 0 for x in a]) / len(a)
p4 = sum([x < 20 for x in a]) / len(a)
p34 = sum([x < 20 and x % 3 == 0 for x in a]) / len(a)
pt = p3+p4-p34
pt


# In[168]:


#5
a = [x for x in range(1,7)]
p3 = sum([x % 2 == 0 for x in a]) / len(a)
p4 = sum([x < 5 for x in a]) / len(a)
p34 = sum([x < 5 and x % 2 == 0 for x in a]) / len(a)
pt = p3+p4-p34
pt


# In[ ]:




