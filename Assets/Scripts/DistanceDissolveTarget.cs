using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDissolveTarget : MonoBehaviour
{
    public GameObject m_objectToTrack = null;

    private Material m_materialRef = null;
    private Renderer m_renderer = null;


    public Renderer Renderer
    {
        get
        {
            if(m_renderer == null)
            {
                m_renderer = this.GetComponent<Renderer>();
            }

            return m_renderer;
        }
    }

    public Material MaterialRef
    {
        get
        {
            if(m_materialRef == null)
            {
                m_materialRef = Renderer.material;
            }

            return m_materialRef;
        }
    }

    private void Awake()
    {
        m_renderer = this.GetComponent<Renderer>();
        m_materialRef = m_renderer.material;
    }

    private void Start()
    {
        m_objectToTrack = GameObject.Find("TrackedObject");
    }

    private void Update()
    {
        if(m_objectToTrack != null)
        {
            MaterialRef.SetVector("_Position", m_objectToTrack.transform.position);
        }
    }

    private void OnDestroy()
    {
        m_materialRef = null;
        if(m_materialRef != null)
        {
            Destroy(m_materialRef);
        }

        m_materialRef = null;
    }

}
