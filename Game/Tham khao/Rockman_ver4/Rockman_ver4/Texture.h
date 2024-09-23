
#ifndef __CTEXTURE_H__
#define __CTEXTURE_H__

#include "Include.h"
#include "CGlobal.h"
class CTexture
{
public:
	CTexture();
	~CTexture();
	LPDIRECT3DTEXTURE9 m_d3dTexture;
	D3DXIMAGE_INFO m_d3dInfo;
public:

	bool LoadImageFromFile(std::string, D3DCOLOR);
	LPDIRECT3DTEXTURE9 GetTexture(){ return m_d3dTexture; };
	int GetImageHeight();
	int GetImageWidth();
};
#endif // !__CTEXTURE_H__
