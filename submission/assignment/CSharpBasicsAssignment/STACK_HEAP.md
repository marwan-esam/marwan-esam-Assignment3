# Memory Model: Stack vs. Heap

### Code Sequence:
```csharp
Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };
Order o2 = o1;
o2.IsPaid = true;
```

---

### Diagram 1: after line 1
```text
      [ STACK ]                          [ HEAP ]
 o1: (Ref: 0xABC)   ----------->    [ Address: 0xABC ]
                                    Type: Order
                                    OrderId: 1
                                    CustomerName: "Ali"
                                    IsPaid: false
```
**Explanation:** `o1` is created on the stack and holds a reference (memory address) pointing to a newly instantiated `Order` object living on the heap.

---

### Diagram 2: after line 2
```text
      [ STACK ]                          [ HEAP ]
 o1: (Ref: 0xABC)   ----------->    [ Address: 0xABC ]
                                    Type: Order
                                    OrderId: 1
                                    CustomerName: "Ali"
                                    IsPaid: false
 
 o2: (Ref: 0xABC)   -----------> 
```
**Explanation:** A new variable `o2` is pushed onto the stack. Because `Order` is a class (reference type), assigning `o2 = o1` simply copies the memory address. Both `o1` and `o2` now point to the exact same object on the heap.

---

### Diagram 3: after line 3
```text
      [ STACK ]                          [ HEAP ]
 o1: (Ref: 0xABC)   ----------->    [ Address: 0xABC ]
                                    Type: Order
                                    OrderId: 1
                                    CustomerName: "Ali"
 o2: (Ref: 0xABC)   ----------->    IsPaid: true
```
**Explanation:** We modify the `IsPaid` field using the `o2` reference. Since `o1` and `o2` share the exact same heap identity (address `0xABC`), the object is updated in one place.

---

### What would be different with structs?
If `Order` were a struct (like the `Point` struct from Part C) instead of a class, it would be a **value type**. 
- In **Diagram 1**, all of the data (OrderId, CustomerName, etc.) would live directly on the stack inside `o1`. No heap allocation would occur.
- In **Diagram 2**, the assignment `o2 = o1` would create a completely separate, independent byte-by-byte copy of the data on the stack for `o2`. 
- In **Diagram 3**, updating `o2.IsPaid = true` would only modify `o2`'s bucket of memory on the stack. `o1.IsPaid` would remain completely unaffected.
