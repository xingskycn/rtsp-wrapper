#ifndef _LIVE_GLOBALS_HH
#define _LIVE_GLOBALS_HH

#if defined _MSC_VER && defined LIVE_EXPORTS
# define LIVE_API __declspec(dllexport)
#elif defined _MSC_VER && defined LIVE_DLL
# define LIVE_API __declspec(dllimport)
#else
# define LIVE_API
#endif

#endif
