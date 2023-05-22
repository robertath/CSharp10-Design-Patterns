# Interpreter Pattern

### Definition:
▪ Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language


### Used when:
▪ When there's a language you can interpret and you can represent statements in the language as abstract syntax trees
▪ And when the grammar is simple
▪ And when the best possible efficiency isn't required

### Consequences:
• It's easy to change and extend the grammar
• It's easy to implement the grammar
• Complex grammars are hard to maintain

### Related to:
• Composite
	• The abstract syntax tree is an interface of the composite pattern
• Iterator
	• You can use iterator to traverse the tree
