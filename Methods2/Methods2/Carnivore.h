#pragma once

class Carnivore {
protected:
    double m_Power;

public:
    Carnivore(double power) : m_Power(power) {}
    virtual ~Carnivore() {}

    double GetPower() const { return m_Power; }

    virtual void Eat(double Weight) = 0;
    virtual void ShowInfo() const = 0;
};