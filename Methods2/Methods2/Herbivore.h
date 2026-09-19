#pragma once

class Herbivore {
protected:
    double m_Weight;
    bool m_Life;

public:
    Herbivore(double weight) : m_Weight(weight), m_Life(true) {}
    virtual ~Herbivore() {}

    double GetWeight() const { return m_Weight; }
    bool IsAlive() const { return m_Life; }
    void SetLife(bool life) { m_Life = life; }


    virtual void EatGrass() = 0;
    virtual void ShowInfo() const = 0;
};
