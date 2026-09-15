Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };

Order o2 = o1;

o2.IsPaid = true;

Diagram 1:
o1:is A varaible of type Order & reference type & reference to an object in the heap memory& in stack.
new :is A keyword that creates an object in the heap memory 
Order { OrderId = 1, CustomerName = "Ali" }: these data members are stored in the heap memory the o1 variable (address) refernce on it 

STACK                         HEAP
+-----------+                +----------------------+
| o1        | -------------> | Order Object         |
|     |                       | OrderId = 1          |
+-----------+                | CustomerName = "omar" |
                             | IsPaid = false       |
                             +----------------------+
Diagram 2: o2 is varaible(refernce type) from object class Order, o2 is reference to the same object in the heap memory as o1.

STACK                         HEAP
+-----------+                +----------------------+
| o1        | -------------> | Order Object         |
| o2        | -------------> | OrderId = 1          |
+-----------+                | CustomerName = "omar" |
                             | IsPaid = true        |
                             +----------------------+
   Digram 3: After changing the value of IsPaid property of o2, the value of IsPaid property of o1 also changed because both o1 and o2 are reference to the same object in the heap memory.
   STACK                         HEAP
+-----------+                +----------------------+
| o1        | -------------> | Order Object         |
| Address   |                | OrderId = 1          |
+-----------+       ┌------> | CustomerName = "omar" |
| o2        | ------┘        | IsPaid = true        |
| Address   |                +----------------------+
+-----------+



Point p2 = p1;
in struct copy samevalue not reference