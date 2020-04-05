#include <iostream>
#include <fstream>
#include <complex>

const float width = 600;
const float height = 600;


int value(int x, int y)
{
	std::complex<float> point((float)x/width-1.5, (float)y/height);
	std::complex<float> z(0,0);
	unsigned int nb_iter = 0;
	while (abs(z) < 2 && nb_iter <= 34)
	{
		z = z*z + point;
		nb_iter++;
	}
	if (nb_iter < 34) return (255*nb_iter)/33;
	else return 0;
}

int main()
{
	std::ofstream image("mandel.ppm");
	if (image.is_open())
	{
		image << "P3\n" << width << " " << height << " 255\n";
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j++)
			{
				int val = value(i, j);
				image << val << ' ' << 0 << ' ' << 0 << "\n";
			}
		}
		image.close();
	}
	else
	{
		std::cout << "cannot open file." << std::endl;
		return 0;
	}
}
