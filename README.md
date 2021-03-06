# Technical Test - Book Store


## Outline
An online bookstore currently sells books for 3 different categories: Crime, Romance, Fantasy.
They have future plans to add more categories into their collection.

Currently all books within the Crime category are discounted by 5%.

The following are the additional charges that would be applied to an order:
  * 10% goods services tax (GST) on the total price
  * $5.95 delivery fee for orders less than $20

The bookstore holds the following collection:
| Title | Author | Genre | Unit Price (AUD) _GST not applied_ |
| --- | --- | --- | --- |
| Unsolved murders | Emily G. Thompson, Amber Hunt | Crime | 10.99 |
| Alice in Wonderland | Lewis Carroll | Fantasy | 5.99 |
| A Little Love Story | Roland Merullo | Romance | 2.40 |
| Heresy | S J Parris | Fantasy | 6.80 |
| The Neverending Story | Michael Ende | Fantasy | 7.99 |
| Jack the Ripper | Philip Sugden | Crime | 16.00 | 
| The Tolkien Years | Greg Hildebrandt | Fantasy | 22.90 |


## Task
Write a simple console application that outputs the total order cost with and without tax for the below purchase:
| Title | Quantity |
| --- | --- |
| Unsolved murders | 1 |
| A Little Love Story | 1 |
| Heresy | 1 |
| Jack the Ripper | 1 |
| The Tolkien Years | 1 |

## Assumptions
I've made the following assumptions based on ambiguous information: _(these would be followed-up with the client to ensure that no false assumptions are made)_
  * The 5% discount on Crime is not already factored in to the unit price
  * Discounts are applied after tax
  * Taxes don't stack (tax-on-tax)
  * Fee amounts are defined as tax-inclusive values
  * Delivery fees are applied by the according to tax-inclusive total
