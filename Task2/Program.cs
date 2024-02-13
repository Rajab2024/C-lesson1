int i1 = 5;
int i2 = 6;
int sum = i1 + i2;
Console.WriteLine(sum);
// هنا المجموع أخذ انتيجار لأن المتغيران الاذنان لهمنا نفس نوع المتغير وهو int
long l1 = 8;
long sum2 = l1 + i1;
Console.WriteLine(sum2);
// هنا المجموع أخذ لونغ لأن احد المتغيران أخذ نوع متغير أشمل وأكبر وهو long
double d1 = 5.5;
double sum3 = d1 + i1;

int product1 = i1 * i2;
long product2 = l1 * i1;
double product3 = i1 * d1;
Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);

int quotient = i1 / i2;
Console.WriteLine(quotient);
// ناتج القسمة اخذت رقم الصفر ولم تأخذ الأرقام العشرية لان نوع القسمة هو انتيجار 

double quotient1 = d1 / i2;
Console.WriteLine(quotient1);
// بينما هنا تمت القسمة بأرقام عشرية ان نوع القسمة دابل


double a = 4.3;
int b = 5;
int c = 2;
double d = 8.5;
double sum4 = (a * b) / (c + d);
Console.WriteLine(sum4);

