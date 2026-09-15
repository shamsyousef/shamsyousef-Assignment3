# Stack & Heap

This file shows how the `Order` reference behaves in memory step by step.

## Diagram 1 — After creating `o1`

```csharp
Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };
```

```text
STACK                         HEAP
-----                         ----
o1 = 0x01  ---------------->  Order Object @ 0x01
                              --------------------
                              OrderId = 1
                              CustomerName = "Ali"
                              Quantity = 0
                              UnitPrice = 0
                              TotalPrice = 0
                              IsPaid = false
                              DiscountPercent = 0
                              ShippingCity = ""
                              Priority = '\0'
                              ItemCode = 0
```

`o1` stores a reference to one `Order` object created on the heap.

---

## Diagram 2 — After assigning `o1` to `o2`

```csharp
Order o2 = o1;
```

```text
STACK                         HEAP
-----                         ----
o1 = 0x01  ----------------\
                            \
                             > Order Object @ 0x01
                            /  --------------------
o2 = 0x01  ----------------/   OrderId = 1
                               CustomerName = "Ali"
                               Quantity = 0
                               UnitPrice = 0
                               TotalPrice = 0
                               IsPaid = false
                               DiscountPercent = 0
                               ShippingCity = ""
                               Priority = '\0'
                               ItemCode = 0
```

`o2` receives a copy of the same reference, so `o1` and `o2` point to the same `Order` object.

---

## Diagram 3 — After changing `o2.IsPaid`

```csharp
o2.IsPaid = true;
```

```text
STACK                         HEAP
-----                         ----
o1 = 0x01  ----------------\
                            \
                             > Order Object @ 0x01
                            /  --------------------
o2 = 0x01  ----------------/   OrderId = 1
                               CustomerName = "Ali"
                               Quantity = 0
                               UnitPrice = 0
                               TotalPrice = 0
                               IsPaid = true
                               DiscountPercent = 0
                               ShippingCity = ""
                               Priority = '\0'
                               ItemCode = 0
```

The same heap object is updated, and both `o1` and `o2` still point to that one object.

---

## What would be different with structs?

`Point` is a `struct`, so it is a value type. When we write:

```csharp
Point p2 = p1;
```

the value is copied instead of copying a reference to the same object.

That means `p1` and `p2` are independent copies. If we change `p2.X`, the value of `p1.X` does not change.
