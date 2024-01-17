# Rotate Array K Times 
 Codility Practice


# Edge Cases
the edge cases are if array is null " we can use a throw new argumentNullexception(nameof(A))"
if the array has the same elements at every index

# Avoid unnecessary rotations
K = K % array.length 

# return a concatenation of both skip and take
we can use return array.Skip(array.length -k).Concat(array.Take(array.Length-k).Concat()).ToArray();