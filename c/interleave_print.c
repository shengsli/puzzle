#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>

#define NTHREADS 2

void *thread_code(void* tid)
{
	int i;
	for (i=0; i<20; i++)
	{
		printf("%d\n",tid);
	}
}

int main (int argc, char* argv[])
{
	pthread_t *threads;
	threads = malloc(NTHREADS*sizeof(pthread_t));
	int i;
	for (i=0; i<NTHREADS; i++)
		pthread_create(&threads[i], NULL, thread_code, (void *)i);
	for (i=0; i<NTHREADS; i++)
		pthread_join(threads[i], NULL);
	return 0;
}
